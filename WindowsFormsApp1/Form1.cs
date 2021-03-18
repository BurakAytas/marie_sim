using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string AC = "";
        private string MAR = "";
        private string MMAR = "";
        private string MBR = "";
        private string IR = "";
        private int PC = 0;
        private string OutReg = "";
        private string InReg = "";
        private List<Memory> Memories = new List<Memory>();
        private List<Tag> Tags = new List<Tag>();
        private List<Command> Commands = new List<Command>();

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Memories.Clear();

            for (int i = 0; i <= 4095; i++)
            {
                Memories.Add(new Memory { Address = i, Value = "", AddressHex = intToHex16(i) });
            }

            AC = "";
            MAR = "";
            MMAR = "";
            MBR = "";
            IR = "";
            PC = 0;
            Tags.Clear();

            showMemory();
            showTags();
            showReg();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Commands.Add(new Command { CommnandHex = "0", CommnandInt = 0, CommandName = "Jns" });
            Commands.Add(new Command { CommnandHex = "1", CommnandInt = 1, CommandName = "Load" });
            Commands.Add(new Command { CommnandHex = "2", CommnandInt = 2, CommandName = "Store" });
            Commands.Add(new Command { CommnandHex = "3", CommnandInt = 3, CommandName = "Add" });
            Commands.Add(new Command { CommnandHex = "4", CommnandInt = 4, CommandName = "Subt" });
            Commands.Add(new Command { CommnandHex = "5", CommnandInt = 5, CommandName = "Input" });
            Commands.Add(new Command { CommnandHex = "6", CommnandInt = 6, CommandName = "Output" });
            Commands.Add(new Command { CommnandHex = "7", CommnandInt = 7, CommandName = "Halt" });
            Commands.Add(new Command { CommnandHex = "8", CommnandInt = 8, CommandName = "Skipcond" });
            Commands.Add(new Command { CommnandHex = "9", CommnandInt = 9, CommandName = "Jump" });
            Commands.Add(new Command { CommnandHex = "A", CommnandInt = 10, CommandName = "Clear" });
            Commands.Add(new Command { CommnandHex = "B", CommnandInt = 11, CommandName = "AddI" });
            Commands.Add(new Command { CommnandHex = "C", CommnandInt = 12, CommandName = "JumpI" });
            Commands.Add(new Command { CommnandHex = "D", CommnandInt = 13, CommandName = "LoadI" });
            Commands.Add(new Command { CommnandHex = "E", CommnandInt = 14, CommandName = "StoreI" });
            Commands.Add(new Command { CommnandHex = "G", CommnandInt = 16, CommandName = "ORG" });
            Commands.Add(new Command { CommnandHex = "H", CommnandInt = 17, CommandName = "END" });
        }

        private string intToHex16(int sayi)
        {
            var hex = sayi.ToString("X");

            if (sayi <= 16) hex = "00" + hex;
            else if (sayi <= 255) hex = "0" + hex;
            //else if (sayi <= 4095) hex = "0" + hex;

            return hex;
        }
        private string intToHex32(int sayi)
        {
            var hex = sayi.ToString("X");

            if (sayi <= 16) hex = "000" + hex;
            else if (sayi <= 255) hex = "00" + hex;
            else if (sayi <= 4095) hex = "00" + hex;

            return hex;
        }


        private void btn_Load_Click(object sender, EventArgs e)
        {
            if (!validateProgram()) return;

            #region MemoriesFirstCreate
            Memories.Clear();

            for (int i = 0; i <= 4095; i++)
            {


                Memories.Add(new Memory { Address = i, Value = "0000", ValueInt = 0, AddressHex = intToHex16(i) });
            }

            int start = int.Parse(txt_Commands.Lines[0].Split(' ')[1], System.Globalization.NumberStyles.HexNumber);

            PC = start;

            //for (int i = start; i < start + txt_Commands.Lines.Count() - 2; i++)
            //{
            //    Memories.Add(new Memory { Address = i, Value = "", AddressHex = i.ToString("X") });
            //}
            #endregion

            #region TagsCreate
            Tags.Clear();
            for (int i = 1; i < txt_Commands.Lines.Count() - 1; i++)
            {
                var commandLine = txt_Commands.Lines[i].Split(' ');

                //if (!Commands.Any(c => c.CommandName == commandLine[0]) && !Tags.Any(c => c.TagName == commandLine[0]) && !Memories.Any(c => c.AddressHex == commandLine[0]))
                if (!Commands.Any(c => c.CommandName == commandLine[0]) && !Tags.Any(c => c.TagName == commandLine[0]))
                {
                    var tagAddr = (start + i - 1);
                    Tags.Add(new Tag { Address = intToHex16(tagAddr), TagName = commandLine[0], AddressInt = tagAddr });
                }
            }
            #endregion

            #region MemoriesUpdate

            for (int i = 0; i < txt_Commands.Lines.Count()-2 ; i++)
            {
                var commandLine = txt_Commands.Lines[i+1].Split(' ');

                if (Tags.Any(c => c.TagName == commandLine[0]))
                {
                    Memories[start+i].isCommand = false;

                    if (commandLine[1].ToUpper() == "DEC")
                    {
                        Memories[start + i].Value = int.Parse(commandLine[2]).ToString("X");
                        Memories[start + i].ValueInt = int.Parse(commandLine[2]);
                    }
                    else if (commandLine[1].ToUpper() == "HEX")
                    {
                        Memories[start + i].Value = commandLine[2];
                        Memories[start + i].ValueInt = int.Parse(commandLine[2], System.Globalization.NumberStyles.HexNumber); 
                    }
                    else
                    {
                        lbl_Exp.Text = "Etiket değeri atanamadı.";
                    }
                }

                //Direk memory set edilebiliyor mu bilmiyorum
                //if (Memories.Any(c => c.AddressHex == commandLine[0]))
                //{

                //}

                if (Commands.Any(c => c.CommandName == commandLine[0]))
                {
                    Memories[start + i].isCommand = true;

                    string memoryVal = Commands.First(c => c.CommandName == commandLine[0]).CommnandHex;

                    if (commandLine.Count() > 1)//Halt komutu parametre almadığı için
                    {
                        if (Tags.Any(c => c.TagName == commandLine[1]))
                        {
                            memoryVal += Tags.First(c => c.TagName == commandLine[1]).Address;
                        }
                        else
                        {
                            memoryVal += commandLine[1];
                        }
                    }
                    else
                    {
                        memoryVal += "000";
                    }

                    Memories[start + i].Value = memoryVal;
                }
            }
            #endregion

            showMemory();
            showTags();
        }

        private void showMemory(int? index =null)
        {
            dg_Memory.DataSource = Memories.Select(c=> new { Adres= c.AddressHex, Deger = c.Value }).ToList();
            if (index.HasValue)
            {
                dg_Memory.Rows[index.Value].Selected = true;

                dg_Memory.CurrentCell = dg_Memory.Rows[index.Value].Cells[0];
            }
        }

        private void showTags()
        {
            dg_Tag.DataSource = Tags.Select(c => new { Etiket = c.TagName, Adres = c.Address }).ToList();
        }

        private bool validateProgram()
        {
            lbl_Exp.Text = "";
            if (string.IsNullOrEmpty(txt_Commands.Text)) lbl_Exp.Text = "Komutlar boş olamaz.";
            else if (!txt_Commands.Lines[0].StartsWith("ORG")) lbl_Exp.Text = "İlk komut ORG olmalı";

            if (string.IsNullOrEmpty(lbl_Exp.Text))
                return true;
            else
                return false;
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            Command command = null ;

            do
            {

                var memory = Memories.First(c => c.Address == PC);
                var index = Memories.IndexOf(memory);
                if (memory.isCommand)
                {
                    #region Fetch

                    MAR = intToHex16(PC);
                    MMAR = memory.Value.ToString();
                    IR = MMAR;
                    PC++;

                    #endregion

                    #region Decode

                    MAR = IR.Substring(1, memory.Value.Length - 1);
                    var komut = IR[0];

                    #endregion

                    #region GetOperand

                    MBR = MMAR;

                    #endregion

                    if (komut == '0') cmdJns(memory.Value.Substring(1, memory.Value.Length - 1));
                    if (komut == '1') cmdLoad(memory.Value.Substring(1, memory.Value.Length - 1));
                    if (komut == '2') cmdStore(memory.Value.Substring(1, memory.Value.Length - 1));
                    if (komut == '3') cmdAdd(memory.Value.Substring(1, memory.Value.Length - 1));
                    if (komut == '4') cmdSubt(memory.Value.Substring(1, memory.Value.Length - 1));
                    if (komut == '5') cmdInput();
                    if (komut == '6') cmdOutput();
                    if (komut == '7')
                    {
                        showReg();
                        showMemory(index);
                        this.Refresh();
                        MessageBox.Show("Bitti");
                        return;
                    }
                    if (komut == '8') cmdSkipcond(memory.Value.Substring(1, memory.Value.Length - 1));
                    if (komut == '9') cmdJump(memory.Value.Substring(1, memory.Value.Length - 1));
                    if (komut == 'A') cmdClear();
                    if (komut == 'B') cmdAddI(memory.Value.Substring(1, memory.Value.Length - 1));
                    if (komut == 'C') cmdJumpI(memory.Value.Substring(1, memory.Value.Length - 1));
                    if (komut == 'D') cmdLoadI(memory.Value.Substring(1, memory.Value.Length - 1));
                    if (komut == 'E') cmdStoreI(memory.Value.Substring(1, memory.Value.Length - 1));
                }
                else
                    PC++;
                
            } while (Memories.Max(c => c.Address)+1 > PC);
            
        }

        private void showReg()
        {
            lbl_Ac.Text = updateHexStr(AC);
            lbl_IR.Text = updateHexStr(IR);
            lbl_Mar.Text = updateHexStr(MAR);
            lbl_Mbr.Text = updateHexStr(MBR);
            lbl_Pc.Text = updateHexStr(intToHex32(PC));
        }

        private string updateHexStr(string hex)
        {
            if (string.IsNullOrEmpty(hex) || hex.Length == 0) hex = "0000";
            else if(hex.Length == 1) hex = "000" + hex;
            else if(hex.Length == 2) hex = "00" + hex;
            else if(hex.Length == 3) hex = "0" + hex;

            return hex;
        }

        private void cmdLoadI(string X)
        {
            MAR = X;
            MMAR = Memories.First(c => c.AddressHex == MAR).Value;
            MBR = MMAR;
            MAR = MBR;
            MMAR = Memories.First(c => c.AddressHex == MAR).Value;
            MBR = MMAR;
            AC = MBR;
        }

        private void cmdStoreI(string X)
        {
            MAR = X;
            MMAR = Memories.First(c => c.AddressHex == MAR).Value;
            MBR = MMAR;
            MAR = MBR;
            MMAR = Memories.First(c => c.AddressHex == MAR).Value;
            MBR = AC;
            Memories.First(c => c.AddressHex == MAR).Value = MBR;
        }

        private void cmdJns(string X)
        {
            MBR = intToHex16(PC);
            MAR = X;
            Memories.First(c => c.AddressHex == MAR).Value = MBR;
            MBR = X;
            var ac = int.Parse(MBR, System.Globalization.NumberStyles.HexNumber) + 1;
            AC = intToHex16(ac);
            PC = ac;
        }

        private void cmdLoad(string X)
        {
            MAR = X;
            MMAR = Memories.First(c => c.AddressHex == MAR).Value;
            MBR = MMAR;
            AC = MBR;
        }

        private void cmdStore(string X)
        {
            MAR = X;
            MBR = AC;
            Memories.First(c => c.AddressHex == MAR).Value = MBR;
        }

        private void cmdAdd(string X)
        {
            MAR = X;
            MMAR = Memories.First(c => c.AddressHex == MAR).Value;
            MBR = MMAR;

            var ac = int.Parse(AC, System.Globalization.NumberStyles.HexNumber);
            var mbr = int.Parse(MBR, System.Globalization.NumberStyles.HexNumber);
            AC = intToHex16((ac + mbr));
        }

        private void cmdSubt(string X)
        {
            MAR = X;
            MMAR = Memories.First(c => c.AddressHex == MAR).Value;
            MBR = MMAR;

            var ac = int.Parse(AC, System.Globalization.NumberStyles.HexNumber);
            var mbr = int.Parse(MBR, System.Globalization.NumberStyles.HexNumber);
            AC = intToHex16((ac - mbr));
        }

        private void cmdInput()
        {
            AC = txt_InReg.Text;
        }

        private void cmdOutput()
        {
            lbl_OutputReg.Text = AC;
        }

        private void cmdSkipcond( string X)
        {
            var ac = int.Parse(AC, System.Globalization.NumberStyles.HexNumber);

            if (X == "000")
            {
                if (ac < 0) PC++;
            }
            else if (X == "400")
            {
                if (ac == 0) PC++;
            }
            else if (X == "800")
            {
                if (ac > 0) PC++;
            }
        }

        private void cmdJump(string X)
        {
            PC = int.Parse(X, System.Globalization.NumberStyles.HexNumber);
        }

        private void cmdClear()
        {
            AC = "0";
        }

        private void cmdAddI(string X)
        {
            MAR = X;
            MMAR = Memories.First(c => c.AddressHex == MAR).Value;
            MBR = MMAR;
            MAR = MBR;
            MMAR = Memories.First(c => c.AddressHex == MAR).Value;
            MBR = MMAR;
            var ac = int.Parse(AC, System.Globalization.NumberStyles.HexNumber);
            var mbr = int.Parse(MBR, System.Globalization.NumberStyles.HexNumber);
            AC = intToHex16((ac + mbr));
        }

        private void cmdJumpI(string X)
        {
            MAR = X;
            MMAR = Memories.First(c => c.AddressHex == MAR).Value;
            MBR = MMAR;
            PC = int.Parse(MBR, System.Globalization.NumberStyles.HexNumber);
        }

        private void lbl_Mar_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_CreateRandom_Click(object sender, EventArgs e)
        {
            if(dg_Memory.Rows.Count == 0)
            {
                MessageBox.Show("Önce Program Yüklenmelidir");
                return;
            }
             
            var start = int.Parse(txt_RndStart.Text, System.Globalization.NumberStyles.HexNumber);
            var end = int.Parse(txt_RndEnd.Text, System.Globalization.NumberStyles.HexNumber);
            var rnd = new Random();

            for (int i = start; i <= end; i++)
            {
                Memories.First(c => c.Address == i).Value = rnd.Next(0, 10).ToString("X");
            }

            showMemory();
        }

        private void txt_Commands_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_RndStart_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_InReg_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Ac_Click(object sender, EventArgs e)
        {

        }
    }
}
