using System;

namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        public void picmass()
        {
            pictureBoxes_array[0] = pictureBox43;
            pictureBoxes_array[1] = pictureBox42;
            pictureBoxes_array[2] = pictureBox41;
            pictureBoxes_array[3] = pictureBox40;
            pictureBoxes_array[4] = pictureBox39;
            pictureBoxes_array[5] = pictureBox38;
            pictureBoxes_array[6] = pictureBox37;
            pictureBoxes_array[7] = pictureBox44;
            pictureBoxes_array[8] = pictureBox45;
            pictureBoxes_array[9] = pictureBox46;
            pictureBoxes_array[10] = pictureBox47;
            pictureBoxes_array[11] = pictureBox48;
            pictureBoxes_array[12] = pictureBox49;
            pictureBoxes_array[13] = pictureBox51;
            pictureBoxes_array[14] = pictureBox58;
            pictureBoxes_array[15] = pictureBox57;
            pictureBoxes_array[16] = pictureBox56;
            pictureBoxes_array[17] = pictureBox55;
            pictureBoxes_array[18] = pictureBox54;
            pictureBoxes_array[19] = pictureBox53;
            pictureBoxes_array[20] = pictureBox52;
            pictureBoxes_array[21] = pictureBox65;
            pictureBoxes_array[22] = pictureBox64;
            pictureBoxes_array[23] = pictureBox63;
            pictureBoxes_array[24] = pictureBox62;
            pictureBoxes_array[25] = pictureBox61;
            pictureBoxes_array[26] = pictureBox60;
            pictureBoxes_array[27] = pictureBox59;
            pictureBoxes_array[28] = pictureBox72;
            pictureBoxes_array[29] = pictureBox71;
            pictureBoxes_array[30] = pictureBox70;
            pictureBoxes_array[31] = pictureBox69;
            pictureBoxes_array[32] = pictureBox68;
            pictureBoxes_array[33] = pictureBox67;
            pictureBoxes_array[34] = pictureBox66;
            

        }

        #region Windows Form Designer generated code
        public class person
        {
            public string name;
            public int health;
            public int maxhealth;
            public int mana;
            public int maxmana;
            public int strengh;
            public int inteligens;
            public int agility;
            public int charisma;
            public int damage;
            public int movepoint;
            public bool magic;
            public bool wepon;
            public int exp;
            public int level;
            public int count;
            public int[,] mcoord = new int[7, 5]; 
            public person() { name = "Pendragon";  strengh = 1; inteligens = 1; agility = 1; charisma = 1; damage = 1;movepoint = 2;wepon = false; magic = false; health = 100; maxhealth=100 ; mana = 100; maxmana = 100; level = 1; exp = 0; }
            public person(int a) { name = "Monster";health = 100+a*10; }
            public person(string n, int h, int s, int i, int ag, int ch, int d,int lev,int coun) { name = n; health = h; strengh = s; inteligens = i; agility = ag; charisma = ch; damage = d; level = lev; count = coun; }

            public static int swordatack(int sworddamage,int mosterhp)
            {
                Random a = new Random();
                mosterhp = mosterhp - sworddamage + a.Next(-sworddamage/2, +sworddamage / 2);
                return(mosterhp);
            }

            public static int monsteratack(int mondamage,int pendhp)
            {
                Random a = new Random();
                pendhp= pendhp - mondamage + a.Next(-mondamage / 2, +mondamage / 2);
                return (pendhp);
            }

            

        }

        public bool death()
        {
            if (Pendragon.health <= 0)
            {
                Random a = new Random();
                int b = a.Next(1, 4);
                switch (b)
                {
                    case 1: if ((Pendragon.inteligens -= a.Next(1, 3)) <= 0) { Pendragon.inteligens = 0; } else Pendragon.inteligens -= a.Next(1, 3); break;
                    case 2: if ((Pendragon.strengh -= a.Next(1, 3)) <= 0) { Pendragon.strengh = 0; } else Pendragon.strengh -= a.Next(1, 3); break;
                    case 3: if ((Pendragon.maxhealth -= a.Next(1, 3) * 10) <= 100) { Pendragon.maxhealth = 100; } else Pendragon.maxhealth -= a.Next(1, 3); break;
                    case 4: if ((Pendragon.maxmana -= a.Next(1, 3) * 10) <= 100) { Pendragon.maxmana = 100; } else Pendragon.maxmana -= a.Next(1, 3); break;


                }
                Pendragon.health = Pendragon.maxhealth;
                Pendragon.mana = Pendragon.maxmana;
                showstats();
                pictureBox50.Location = pictureBox29.Location;
                tabPage2.Parent = null;
                button11.Enabled = true;
                button5.Enabled = true;
                return (true);
            }
            else return (false);


        }
        public void fightchek()
        {
            picmass();
            for (int i = 0; i < 35; i++)
            {

                

                  if (pictureBoxes_array[i].Visible==false) { GlobalData.coord[i] = 0; }

                

            }
        }

        public void showstats()
            {
            
            label1.Text = "Здоровье: " + Pendragon.health.ToString() + "/" + Pendragon.maxhealth.ToString() + "\n" + "Мана: " + Pendragon.mana.ToString() + "/" + Pendragon.maxmana.ToString() + "\n" + "Сила:" + Pendragon.strengh.ToString() + "\n" + "Интелект:" + Pendragon.inteligens.ToString() + "\n" + "Ловкость:" + Pendragon.agility.ToString() + "\n" + "Харизма: " + Pendragon.charisma.ToString() + "\n" + "Урон:" + Pendragon.damage.ToString() + "\n Накопленный опыт: "+ Pendragon.exp.ToString();
            
            button12.Text = "Атака оружием \n"+(Pendragon.damage + Pendragon.strengh * 5).ToString();
            button10.Text = "Божественный свет \n"+(Pendragon.damage + Pendragon.inteligens * 5).ToString();
        }

       public int generatemonlvl()
        {
            int monsterlvl;
            Random a = new Random();

            if ((Pendragon.level - 5) > 0) monsterlvl = a.Next(Pendragon.level - 5, Pendragon.level + 5);
            else monsterlvl = 1;

            return (monsterlvl);
        }
        // определить количество монстров
        public int generatemonsters()
        {
            Random count = new Random();
            
            int a =count.Next(1, 9);
            if (a == 1) { this.label4.Visible = true; this.label5.Visible = false; this.label6.Visible = false; this.label7.Visible = false; this.label8.Visible = false; this.label9.Visible = false; this.label10.Visible = false; this.label11.Visible = false; }
            else if (a == 2) { this.label4.Visible = true; this.label5.Visible = true; this.label6.Visible = false; this.label7.Visible = false; this.label8.Visible = false; this.label9.Visible = false; this.label10.Visible = false; this.label11.Visible = false; }
            else if (a == 3) { this.label4.Visible = true; this.label5.Visible = true; this.label6.Visible = true; this.label7.Visible = false; this.label8.Visible = false; this.label9.Visible = false; this.label10.Visible = false; this.label11.Visible = false; }
            else if (a == 4) { this.label4.Visible = true; this.label5.Visible = true; this.label6.Visible = true; this.label7.Visible = true; this.label8.Visible = false; this.label9.Visible = false; this.label10.Visible = false; this.label11.Visible = false; }
            else if (a == 5) { this.label4.Visible = true; this.label5.Visible = true; this.label6.Visible = true; this.label7.Visible = true; this.label8.Visible = true; this.label9.Visible = false; this.label10.Visible = false; this.label11.Visible = false; }
            else if (a == 6) { this.label4.Visible = true; this.label5.Visible = true; this.label6.Visible = true; this.label7.Visible = true; this.label8.Visible = true; this.label9.Visible = true; this.label10.Visible = false; this.label11.Visible = false; }
            else if (a == 7) { this.label4.Visible = true; this.label5.Visible = true; this.label6.Visible = true; this.label7.Visible = true; this.label8.Visible = true; this.label9.Visible = true; this.label10.Visible = true; this.label11.Visible = false; }
            else if (a == 8) { this.label4.Visible = true; this.label5.Visible = true; this.label6.Visible = true; this.label7.Visible = true; this.label8.Visible = true; this.label9.Visible = true; this.label10.Visible = true; this.label11.Visible = true; }
            label4.Text = "Зловещий портал"; label5.Text = "Монстр"; label6.Text = "Монстр"; label7.Text = "Монстр"; label8.Text = "Монстр"; label9.Text = "Монстр"; label10.Text = "Монстр"; label11.Text = "Монстр";
            return (a);

        }
        
      



        public void move()
        {
            Random rnd = new Random();
            int rndpoint = rnd.Next(1, 4);
            if (rndpoint == 1) { pictureBox37.Left -= 75; }
            if (rndpoint == 2) { pictureBox37.Top -= 81; }
            if (rndpoint == 3) { pictureBox37.Left += 75; }
            if (rndpoint == 4) { pictureBox37.Top += 81; }
        }

      


        public class item
        {

            public string name;
            public int health;
            public int maxhealth;
            public int strengh;
            public int inteligens;
            public int agility;
            public int charisma;
            public int damage;

            public int id;

            public item(string n, int h,int mh, int s, int i, int ag, int ch, int d, int identif) { name = n; health = h;maxhealth = mh; strengh = s; inteligens = i; agility = ag; charisma = ch; damage = d; id = identif; }

        }



        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button11 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox66 = new System.Windows.Forms.PictureBox();
            this.pictureBox67 = new System.Windows.Forms.PictureBox();
            this.pictureBox68 = new System.Windows.Forms.PictureBox();
            this.pictureBox69 = new System.Windows.Forms.PictureBox();
            this.pictureBox70 = new System.Windows.Forms.PictureBox();
            this.pictureBox71 = new System.Windows.Forms.PictureBox();
            this.pictureBox72 = new System.Windows.Forms.PictureBox();
            this.pictureBox59 = new System.Windows.Forms.PictureBox();
            this.pictureBox60 = new System.Windows.Forms.PictureBox();
            this.pictureBox61 = new System.Windows.Forms.PictureBox();
            this.pictureBox62 = new System.Windows.Forms.PictureBox();
            this.pictureBox63 = new System.Windows.Forms.PictureBox();
            this.pictureBox64 = new System.Windows.Forms.PictureBox();
            this.pictureBox65 = new System.Windows.Forms.PictureBox();
            this.pictureBox52 = new System.Windows.Forms.PictureBox();
            this.pictureBox53 = new System.Windows.Forms.PictureBox();
            this.pictureBox54 = new System.Windows.Forms.PictureBox();
            this.pictureBox55 = new System.Windows.Forms.PictureBox();
            this.pictureBox56 = new System.Windows.Forms.PictureBox();
            this.pictureBox57 = new System.Windows.Forms.PictureBox();
            this.pictureBox58 = new System.Windows.Forms.PictureBox();
            this.pictureBox51 = new System.Windows.Forms.PictureBox();
            this.pictureBox49 = new System.Windows.Forms.PictureBox();
            this.pictureBox48 = new System.Windows.Forms.PictureBox();
            this.pictureBox47 = new System.Windows.Forms.PictureBox();
            this.pictureBox46 = new System.Windows.Forms.PictureBox();
            this.pictureBox45 = new System.Windows.Forms.PictureBox();
            this.pictureBox44 = new System.Windows.Forms.PictureBox();
            this.pictureBox43 = new System.Windows.Forms.PictureBox();
            this.pictureBox42 = new System.Windows.Forms.PictureBox();
            this.pictureBox41 = new System.Windows.Forms.PictureBox();
            this.pictureBox40 = new System.Windows.Forms.PictureBox();
            this.pictureBox39 = new System.Windows.Forms.PictureBox();
            this.pictureBox38 = new System.Windows.Forms.PictureBox();
            this.pictureBox37 = new System.Windows.Forms.PictureBox();
            this.pictureBox50 = new System.Windows.Forms.PictureBox();
            this.pictureBox31 = new System.Windows.Forms.PictureBox();
            this.pictureBox32 = new System.Windows.Forms.PictureBox();
            this.pictureBox34 = new System.Windows.Forms.PictureBox();
            this.pictureBox35 = new System.Windows.Forms.PictureBox();
            this.pictureBox36 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            this.pictureBox28 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox30 = new System.Windows.Forms.PictureBox();
            this.pictureBox29 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.pictureBox33 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox73 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox66)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox67)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox68)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox69)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox70)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox71)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox72)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox59)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox60)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox61)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox62)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox63)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox64)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox65)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox53)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox54)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox55)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox56)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox57)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox58)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox49)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox73)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(355, 587);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(389, 111);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(31, 514);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(266, 27);
            this.button6.TabIndex = 10;
            this.button6.Text = "Инвентарь";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.richTextBox2.Location = new System.Drawing.Point(136, 49);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(219, 424);
            this.richTextBox2.TabIndex = 12;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 554);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(50, 588);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 20);
            this.listBox1.TabIndex = 22;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(176, 588);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(56, 20);
            this.listBox2.TabIndex = 23;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button11.FlatAppearance.BorderSize = 2;
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(721, 9);
            this.button11.Margin = new System.Windows.Forms.Padding(0);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(126, 51);
            this.button11.TabIndex = 31;
            this.button11.Text = "Перейти в локацию";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.pictureBox66);
            this.groupBox1.Controls.Add(this.pictureBox67);
            this.groupBox1.Controls.Add(this.pictureBox68);
            this.groupBox1.Controls.Add(this.pictureBox69);
            this.groupBox1.Controls.Add(this.pictureBox70);
            this.groupBox1.Controls.Add(this.pictureBox71);
            this.groupBox1.Controls.Add(this.pictureBox72);
            this.groupBox1.Controls.Add(this.pictureBox59);
            this.groupBox1.Controls.Add(this.pictureBox60);
            this.groupBox1.Controls.Add(this.pictureBox61);
            this.groupBox1.Controls.Add(this.pictureBox62);
            this.groupBox1.Controls.Add(this.pictureBox63);
            this.groupBox1.Controls.Add(this.pictureBox64);
            this.groupBox1.Controls.Add(this.pictureBox65);
            this.groupBox1.Controls.Add(this.pictureBox52);
            this.groupBox1.Controls.Add(this.pictureBox53);
            this.groupBox1.Controls.Add(this.pictureBox54);
            this.groupBox1.Controls.Add(this.pictureBox55);
            this.groupBox1.Controls.Add(this.pictureBox56);
            this.groupBox1.Controls.Add(this.pictureBox57);
            this.groupBox1.Controls.Add(this.pictureBox58);
            this.groupBox1.Controls.Add(this.pictureBox51);
            this.groupBox1.Controls.Add(this.pictureBox49);
            this.groupBox1.Controls.Add(this.pictureBox48);
            this.groupBox1.Controls.Add(this.pictureBox47);
            this.groupBox1.Controls.Add(this.pictureBox46);
            this.groupBox1.Controls.Add(this.pictureBox45);
            this.groupBox1.Controls.Add(this.pictureBox44);
            this.groupBox1.Controls.Add(this.pictureBox43);
            this.groupBox1.Controls.Add(this.pictureBox42);
            this.groupBox1.Controls.Add(this.pictureBox41);
            this.groupBox1.Controls.Add(this.pictureBox40);
            this.groupBox1.Controls.Add(this.pictureBox39);
            this.groupBox1.Controls.Add(this.pictureBox38);
            this.groupBox1.Controls.Add(this.pictureBox37);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pictureBox50);
            this.groupBox1.Controls.Add(this.pictureBox31);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.pictureBox32);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.pictureBox34);
            this.groupBox1.Controls.Add(this.pictureBox35);
            this.groupBox1.Controls.Add(this.pictureBox36);
            this.groupBox1.Controls.Add(this.pictureBox23);
            this.groupBox1.Controls.Add(this.pictureBox24);
            this.groupBox1.Controls.Add(this.pictureBox26);
            this.groupBox1.Controls.Add(this.pictureBox27);
            this.groupBox1.Controls.Add(this.pictureBox28);
            this.groupBox1.Controls.Add(this.pictureBox16);
            this.groupBox1.Controls.Add(this.pictureBox18);
            this.groupBox1.Controls.Add(this.pictureBox19);
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Controls.Add(this.pictureBox20);
            this.groupBox1.Controls.Add(this.pictureBox21);
            this.groupBox1.Controls.Add(this.pictureBox10);
            this.groupBox1.Controls.Add(this.pictureBox11);
            this.groupBox1.Controls.Add(this.pictureBox12);
            this.groupBox1.Controls.Add(this.pictureBox13);
            this.groupBox1.Controls.Add(this.pictureBox14);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox6);
            this.groupBox1.Controls.Add(this.pictureBox7);
            this.groupBox1.Controls.Add(this.pictureBox8);
            this.groupBox1.Controls.Add(this.pictureBox9);
            this.groupBox1.Controls.Add(this.pictureBox30);
            this.groupBox1.Controls.Add(this.pictureBox29);
            this.groupBox1.Controls.Add(this.pictureBox22);
            this.groupBox1.Controls.Add(this.pictureBox15);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox25);
            this.groupBox1.Controls.Add(this.pictureBox33);
            this.groupBox1.Controls.Add(this.pictureBox17);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(857, 500);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Карта мира";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(707, 234);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(144, 77);
            this.button9.TabIndex = 118;
            this.button9.Text = "Получить Великий божественный меч";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(721, 463);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 23);
            this.button4.TabIndex = 34;
            this.button4.Text = "На юг";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(721, 434);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 23);
            this.button3.TabIndex = 33;
            this.button3.Text = "На восток";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(721, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 32;
            this.button2.Text = "На север";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(721, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "На запад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button7.FlatAppearance.BorderSize = 2;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(721, 126);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(126, 31);
            this.button7.TabIndex = 33;
            this.button7.Text = "Бой";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(721, 78);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 31);
            this.button5.TabIndex = 32;
            this.button5.Text = "Встреча";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(336, 536);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(857, 35);
            this.button8.TabIndex = 31;
            this.button8.Text = "Конец хода";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(332, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(868, 533);
            this.tabControl1.TabIndex = 32;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(860, 504);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Карта мира";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.button10);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.button12);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.richTextBox2);
            this.tabPage2.Controls.Add(this.pictureBox73);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(860, 504);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Бой";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(636, 298);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 17);
            this.label12.TabIndex = 44;
            this.label12.Text = "Повелитель монстров";
            // 
            // button10
            // 
            this.button10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button10.Location = new System.Drawing.Point(3, 213);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(122, 68);
            this.button10.TabIndex = 34;
            this.button10.Text = "Божественный свет";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(636, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 43;
            this.label8.Text = "Монстр";
            // 
            // button12
            // 
            this.button12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button12.Location = new System.Drawing.Point(3, 131);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(89, 76);
            this.button12.TabIndex = 33;
            this.button12.Text = "Атака оружием";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(636, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 42;
            this.label9.Text = "Монстр";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(636, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 17);
            this.label10.TabIndex = 41;
            this.label10.Text = "Монстр";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(636, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 17);
            this.label11.TabIndex = 40;
            this.label11.Text = "Монстр";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(636, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 39;
            this.label7.Text = "Монстр";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(636, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "Монстр";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(636, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "Монстр";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(636, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Зловещий портал";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Логи боя";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(604, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "инф";
            // 
            // pictureBox66
            // 
            this.pictureBox66.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox66.BackColor = System.Drawing.Color.Red;
            this.pictureBox66.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox66.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox66.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox66.Image")));
            this.pictureBox66.Location = new System.Drawing.Point(660, 399);
            this.pictureBox66.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox66.Name = "pictureBox66";
            this.pictureBox66.Size = new System.Drawing.Size(40, 40);
            this.pictureBox66.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox66.TabIndex = 117;
            this.pictureBox66.TabStop = false;
            // 
            // pictureBox67
            // 
            this.pictureBox67.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox67.BackColor = System.Drawing.Color.Red;
            this.pictureBox67.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox67.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox67.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox67.Image")));
            this.pictureBox67.Location = new System.Drawing.Point(560, 399);
            this.pictureBox67.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox67.Name = "pictureBox67";
            this.pictureBox67.Size = new System.Drawing.Size(40, 40);
            this.pictureBox67.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox67.TabIndex = 116;
            this.pictureBox67.TabStop = false;
            // 
            // pictureBox68
            // 
            this.pictureBox68.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox68.BackColor = System.Drawing.Color.Red;
            this.pictureBox68.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox68.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox68.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox68.Image")));
            this.pictureBox68.Location = new System.Drawing.Point(460, 399);
            this.pictureBox68.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox68.Name = "pictureBox68";
            this.pictureBox68.Size = new System.Drawing.Size(40, 40);
            this.pictureBox68.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox68.TabIndex = 115;
            this.pictureBox68.TabStop = false;
            // 
            // pictureBox69
            // 
            this.pictureBox69.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox69.BackColor = System.Drawing.Color.Red;
            this.pictureBox69.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox69.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox69.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox69.Image")));
            this.pictureBox69.Location = new System.Drawing.Point(360, 399);
            this.pictureBox69.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox69.Name = "pictureBox69";
            this.pictureBox69.Size = new System.Drawing.Size(40, 40);
            this.pictureBox69.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox69.TabIndex = 114;
            this.pictureBox69.TabStop = false;
            // 
            // pictureBox70
            // 
            this.pictureBox70.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox70.BackColor = System.Drawing.Color.Red;
            this.pictureBox70.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox70.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox70.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox70.Image")));
            this.pictureBox70.Location = new System.Drawing.Point(260, 399);
            this.pictureBox70.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox70.Name = "pictureBox70";
            this.pictureBox70.Size = new System.Drawing.Size(40, 40);
            this.pictureBox70.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox70.TabIndex = 113;
            this.pictureBox70.TabStop = false;
            // 
            // pictureBox71
            // 
            this.pictureBox71.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox71.BackColor = System.Drawing.Color.Red;
            this.pictureBox71.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox71.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox71.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox71.Image")));
            this.pictureBox71.Location = new System.Drawing.Point(160, 399);
            this.pictureBox71.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox71.Name = "pictureBox71";
            this.pictureBox71.Size = new System.Drawing.Size(40, 40);
            this.pictureBox71.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox71.TabIndex = 112;
            this.pictureBox71.TabStop = false;
            // 
            // pictureBox72
            // 
            this.pictureBox72.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox72.BackColor = System.Drawing.Color.Red;
            this.pictureBox72.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox72.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox72.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox72.Image")));
            this.pictureBox72.Location = new System.Drawing.Point(60, 399);
            this.pictureBox72.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox72.Name = "pictureBox72";
            this.pictureBox72.Size = new System.Drawing.Size(40, 40);
            this.pictureBox72.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox72.TabIndex = 111;
            this.pictureBox72.TabStop = false;
            // 
            // pictureBox59
            // 
            this.pictureBox59.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox59.BackColor = System.Drawing.Color.Red;
            this.pictureBox59.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox59.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox59.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox59.Image")));
            this.pictureBox59.Location = new System.Drawing.Point(660, 300);
            this.pictureBox59.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox59.Name = "pictureBox59";
            this.pictureBox59.Size = new System.Drawing.Size(40, 40);
            this.pictureBox59.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox59.TabIndex = 110;
            this.pictureBox59.TabStop = false;
            // 
            // pictureBox60
            // 
            this.pictureBox60.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox60.BackColor = System.Drawing.Color.Red;
            this.pictureBox60.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox60.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox60.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox60.Image")));
            this.pictureBox60.Location = new System.Drawing.Point(560, 300);
            this.pictureBox60.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox60.Name = "pictureBox60";
            this.pictureBox60.Size = new System.Drawing.Size(40, 40);
            this.pictureBox60.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox60.TabIndex = 109;
            this.pictureBox60.TabStop = false;
            // 
            // pictureBox61
            // 
            this.pictureBox61.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox61.BackColor = System.Drawing.Color.Red;
            this.pictureBox61.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox61.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox61.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox61.Image")));
            this.pictureBox61.Location = new System.Drawing.Point(460, 300);
            this.pictureBox61.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox61.Name = "pictureBox61";
            this.pictureBox61.Size = new System.Drawing.Size(40, 40);
            this.pictureBox61.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox61.TabIndex = 108;
            this.pictureBox61.TabStop = false;
            // 
            // pictureBox62
            // 
            this.pictureBox62.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox62.BackColor = System.Drawing.Color.Red;
            this.pictureBox62.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox62.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox62.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox62.Image")));
            this.pictureBox62.Location = new System.Drawing.Point(360, 300);
            this.pictureBox62.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox62.Name = "pictureBox62";
            this.pictureBox62.Size = new System.Drawing.Size(40, 40);
            this.pictureBox62.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox62.TabIndex = 107;
            this.pictureBox62.TabStop = false;
            // 
            // pictureBox63
            // 
            this.pictureBox63.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox63.BackColor = System.Drawing.Color.Red;
            this.pictureBox63.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox63.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox63.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox63.Image")));
            this.pictureBox63.Location = new System.Drawing.Point(260, 300);
            this.pictureBox63.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox63.Name = "pictureBox63";
            this.pictureBox63.Size = new System.Drawing.Size(40, 40);
            this.pictureBox63.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox63.TabIndex = 106;
            this.pictureBox63.TabStop = false;
            // 
            // pictureBox64
            // 
            this.pictureBox64.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox64.BackColor = System.Drawing.Color.Red;
            this.pictureBox64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox64.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox64.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox64.Image")));
            this.pictureBox64.Location = new System.Drawing.Point(160, 300);
            this.pictureBox64.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox64.Name = "pictureBox64";
            this.pictureBox64.Size = new System.Drawing.Size(40, 40);
            this.pictureBox64.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox64.TabIndex = 105;
            this.pictureBox64.TabStop = false;
            // 
            // pictureBox65
            // 
            this.pictureBox65.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox65.BackColor = System.Drawing.Color.Red;
            this.pictureBox65.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox65.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox65.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox65.Image")));
            this.pictureBox65.Location = new System.Drawing.Point(60, 300);
            this.pictureBox65.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox65.Name = "pictureBox65";
            this.pictureBox65.Size = new System.Drawing.Size(40, 40);
            this.pictureBox65.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox65.TabIndex = 104;
            this.pictureBox65.TabStop = false;
            // 
            // pictureBox52
            // 
            this.pictureBox52.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox52.BackColor = System.Drawing.Color.Red;
            this.pictureBox52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox52.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox52.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox52.Image")));
            this.pictureBox52.Location = new System.Drawing.Point(660, 200);
            this.pictureBox52.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox52.Name = "pictureBox52";
            this.pictureBox52.Size = new System.Drawing.Size(40, 40);
            this.pictureBox52.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox52.TabIndex = 103;
            this.pictureBox52.TabStop = false;
            // 
            // pictureBox53
            // 
            this.pictureBox53.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox53.BackColor = System.Drawing.Color.Red;
            this.pictureBox53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox53.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox53.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox53.Image")));
            this.pictureBox53.Location = new System.Drawing.Point(560, 200);
            this.pictureBox53.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox53.Name = "pictureBox53";
            this.pictureBox53.Size = new System.Drawing.Size(40, 40);
            this.pictureBox53.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox53.TabIndex = 102;
            this.pictureBox53.TabStop = false;
            // 
            // pictureBox54
            // 
            this.pictureBox54.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox54.BackColor = System.Drawing.Color.Red;
            this.pictureBox54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox54.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox54.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox54.Image")));
            this.pictureBox54.Location = new System.Drawing.Point(460, 200);
            this.pictureBox54.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox54.Name = "pictureBox54";
            this.pictureBox54.Size = new System.Drawing.Size(40, 40);
            this.pictureBox54.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox54.TabIndex = 101;
            this.pictureBox54.TabStop = false;
            // 
            // pictureBox55
            // 
            this.pictureBox55.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox55.BackColor = System.Drawing.Color.Red;
            this.pictureBox55.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox55.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox55.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox55.Image")));
            this.pictureBox55.Location = new System.Drawing.Point(360, 200);
            this.pictureBox55.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox55.Name = "pictureBox55";
            this.pictureBox55.Size = new System.Drawing.Size(40, 40);
            this.pictureBox55.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox55.TabIndex = 100;
            this.pictureBox55.TabStop = false;
            // 
            // pictureBox56
            // 
            this.pictureBox56.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox56.BackColor = System.Drawing.Color.Red;
            this.pictureBox56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox56.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox56.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox56.Image")));
            this.pictureBox56.Location = new System.Drawing.Point(260, 200);
            this.pictureBox56.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox56.Name = "pictureBox56";
            this.pictureBox56.Size = new System.Drawing.Size(40, 40);
            this.pictureBox56.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox56.TabIndex = 99;
            this.pictureBox56.TabStop = false;
            // 
            // pictureBox57
            // 
            this.pictureBox57.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox57.BackColor = System.Drawing.Color.Red;
            this.pictureBox57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox57.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox57.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox57.Image")));
            this.pictureBox57.Location = new System.Drawing.Point(160, 200);
            this.pictureBox57.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox57.Name = "pictureBox57";
            this.pictureBox57.Size = new System.Drawing.Size(40, 40);
            this.pictureBox57.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox57.TabIndex = 98;
            this.pictureBox57.TabStop = false;
            // 
            // pictureBox58
            // 
            this.pictureBox58.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox58.BackColor = System.Drawing.Color.Red;
            this.pictureBox58.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox58.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox58.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox58.Image")));
            this.pictureBox58.Location = new System.Drawing.Point(60, 200);
            this.pictureBox58.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox58.Name = "pictureBox58";
            this.pictureBox58.Size = new System.Drawing.Size(40, 40);
            this.pictureBox58.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox58.TabIndex = 97;
            this.pictureBox58.TabStop = false;
            // 
            // pictureBox51
            // 
            this.pictureBox51.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox51.BackColor = System.Drawing.Color.Red;
            this.pictureBox51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox51.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox51.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox51.Image")));
            this.pictureBox51.Location = new System.Drawing.Point(660, 100);
            this.pictureBox51.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox51.Name = "pictureBox51";
            this.pictureBox51.Size = new System.Drawing.Size(40, 40);
            this.pictureBox51.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox51.TabIndex = 96;
            this.pictureBox51.TabStop = false;
            // 
            // pictureBox49
            // 
            this.pictureBox49.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox49.BackColor = System.Drawing.Color.Red;
            this.pictureBox49.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox49.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox49.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox49.Image")));
            this.pictureBox49.Location = new System.Drawing.Point(560, 100);
            this.pictureBox49.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox49.Name = "pictureBox49";
            this.pictureBox49.Size = new System.Drawing.Size(40, 40);
            this.pictureBox49.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox49.TabIndex = 95;
            this.pictureBox49.TabStop = false;
            // 
            // pictureBox48
            // 
            this.pictureBox48.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox48.BackColor = System.Drawing.Color.Red;
            this.pictureBox48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox48.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox48.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox48.Image")));
            this.pictureBox48.Location = new System.Drawing.Point(460, 100);
            this.pictureBox48.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox48.Name = "pictureBox48";
            this.pictureBox48.Size = new System.Drawing.Size(40, 40);
            this.pictureBox48.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox48.TabIndex = 94;
            this.pictureBox48.TabStop = false;
            // 
            // pictureBox47
            // 
            this.pictureBox47.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox47.BackColor = System.Drawing.Color.Red;
            this.pictureBox47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox47.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox47.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox47.Image")));
            this.pictureBox47.Location = new System.Drawing.Point(360, 100);
            this.pictureBox47.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox47.Name = "pictureBox47";
            this.pictureBox47.Size = new System.Drawing.Size(40, 40);
            this.pictureBox47.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox47.TabIndex = 93;
            this.pictureBox47.TabStop = false;
            // 
            // pictureBox46
            // 
            this.pictureBox46.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox46.BackColor = System.Drawing.Color.Red;
            this.pictureBox46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox46.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox46.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox46.Image")));
            this.pictureBox46.Location = new System.Drawing.Point(260, 100);
            this.pictureBox46.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox46.Name = "pictureBox46";
            this.pictureBox46.Size = new System.Drawing.Size(40, 40);
            this.pictureBox46.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox46.TabIndex = 92;
            this.pictureBox46.TabStop = false;
            // 
            // pictureBox45
            // 
            this.pictureBox45.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox45.BackColor = System.Drawing.Color.Red;
            this.pictureBox45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox45.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox45.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox45.Image")));
            this.pictureBox45.Location = new System.Drawing.Point(160, 100);
            this.pictureBox45.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox45.Name = "pictureBox45";
            this.pictureBox45.Size = new System.Drawing.Size(40, 40);
            this.pictureBox45.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox45.TabIndex = 91;
            this.pictureBox45.TabStop = false;
            // 
            // pictureBox44
            // 
            this.pictureBox44.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox44.BackColor = System.Drawing.Color.Red;
            this.pictureBox44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox44.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox44.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox44.Image")));
            this.pictureBox44.Location = new System.Drawing.Point(60, 100);
            this.pictureBox44.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox44.Name = "pictureBox44";
            this.pictureBox44.Size = new System.Drawing.Size(40, 40);
            this.pictureBox44.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox44.TabIndex = 90;
            this.pictureBox44.TabStop = false;
            this.pictureBox44.Click += new System.EventHandler(this.pictureBox44_Click);
            // 
            // pictureBox43
            // 
            this.pictureBox43.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox43.BackColor = System.Drawing.Color.Red;
            this.pictureBox43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox43.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox43.Image = global::WindowsFormsApp1.Properties.Resources.Портал1;
            this.pictureBox43.Location = new System.Drawing.Point(60, 0);
            this.pictureBox43.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox43.Name = "pictureBox43";
            this.pictureBox43.Size = new System.Drawing.Size(40, 40);
            this.pictureBox43.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox43.TabIndex = 89;
            this.pictureBox43.TabStop = false;
            this.pictureBox43.Click += new System.EventHandler(this.pictureBox43_Click);
            // 
            // pictureBox42
            // 
            this.pictureBox42.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox42.BackColor = System.Drawing.Color.Red;
            this.pictureBox42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox42.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox42.Image = global::WindowsFormsApp1.Properties.Resources.Портал1;
            this.pictureBox42.Location = new System.Drawing.Point(160, 0);
            this.pictureBox42.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox42.Name = "pictureBox42";
            this.pictureBox42.Size = new System.Drawing.Size(40, 40);
            this.pictureBox42.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox42.TabIndex = 88;
            this.pictureBox42.TabStop = false;
            // 
            // pictureBox41
            // 
            this.pictureBox41.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox41.BackColor = System.Drawing.Color.Red;
            this.pictureBox41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox41.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox41.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox41.Image")));
            this.pictureBox41.Location = new System.Drawing.Point(260, 0);
            this.pictureBox41.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox41.Name = "pictureBox41";
            this.pictureBox41.Size = new System.Drawing.Size(40, 40);
            this.pictureBox41.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox41.TabIndex = 87;
            this.pictureBox41.TabStop = false;
            // 
            // pictureBox40
            // 
            this.pictureBox40.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox40.BackColor = System.Drawing.Color.Red;
            this.pictureBox40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox40.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox40.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox40.Image")));
            this.pictureBox40.Location = new System.Drawing.Point(360, 0);
            this.pictureBox40.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox40.Name = "pictureBox40";
            this.pictureBox40.Size = new System.Drawing.Size(40, 40);
            this.pictureBox40.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox40.TabIndex = 86;
            this.pictureBox40.TabStop = false;
            // 
            // pictureBox39
            // 
            this.pictureBox39.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox39.BackColor = System.Drawing.Color.Red;
            this.pictureBox39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox39.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox39.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox39.Image")));
            this.pictureBox39.Location = new System.Drawing.Point(460, 0);
            this.pictureBox39.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox39.Name = "pictureBox39";
            this.pictureBox39.Size = new System.Drawing.Size(40, 40);
            this.pictureBox39.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox39.TabIndex = 85;
            this.pictureBox39.TabStop = false;
            // 
            // pictureBox38
            // 
            this.pictureBox38.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox38.BackColor = System.Drawing.Color.Red;
            this.pictureBox38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox38.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox38.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox38.Image")));
            this.pictureBox38.Location = new System.Drawing.Point(560, 0);
            this.pictureBox38.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox38.Name = "pictureBox38";
            this.pictureBox38.Size = new System.Drawing.Size(40, 40);
            this.pictureBox38.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox38.TabIndex = 84;
            this.pictureBox38.TabStop = false;
            // 
            // pictureBox37
            // 
            this.pictureBox37.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox37.BackColor = System.Drawing.Color.Red;
            this.pictureBox37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox37.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox37.Image = global::WindowsFormsApp1.Properties.Resources.Портал1;
            this.pictureBox37.Location = new System.Drawing.Point(660, 0);
            this.pictureBox37.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox37.Name = "pictureBox37";
            this.pictureBox37.Size = new System.Drawing.Size(40, 40);
            this.pictureBox37.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox37.TabIndex = 83;
            this.pictureBox37.TabStop = false;
            // 
            // pictureBox50
            // 
            this.pictureBox50.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox50.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.pictureBox50.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox50.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox50.Image")));
            this.pictureBox50.Location = new System.Drawing.Point(0, 399);
            this.pictureBox50.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox50.Name = "pictureBox50";
            this.pictureBox50.Size = new System.Drawing.Size(40, 40);
            this.pictureBox50.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox50.TabIndex = 31;
            this.pictureBox50.TabStop = false;
            this.pictureBox50.Click += new System.EventHandler(this.pictureBox50_Click);
            // 
            // pictureBox31
            // 
            this.pictureBox31.BackColor = System.Drawing.Color.Black;
            this.pictureBox31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox31.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox31.Image")));
            this.pictureBox31.Location = new System.Drawing.Point(600, 399);
            this.pictureBox31.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox31.Name = "pictureBox31";
            this.pictureBox31.Size = new System.Drawing.Size(100, 100);
            this.pictureBox31.TabIndex = 82;
            this.pictureBox31.TabStop = false;
            this.pictureBox31.Click += new System.EventHandler(this.pictureBox31_Click);
            // 
            // pictureBox32
            // 
            this.pictureBox32.BackColor = System.Drawing.Color.Black;
            this.pictureBox32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox32.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox32.Image")));
            this.pictureBox32.Location = new System.Drawing.Point(600, 299);
            this.pictureBox32.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox32.Name = "pictureBox32";
            this.pictureBox32.Size = new System.Drawing.Size(100, 100);
            this.pictureBox32.TabIndex = 81;
            this.pictureBox32.TabStop = false;
            // 
            // pictureBox34
            // 
            this.pictureBox34.BackColor = System.Drawing.Color.Black;
            this.pictureBox34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox34.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox34.Image")));
            this.pictureBox34.Location = new System.Drawing.Point(600, 200);
            this.pictureBox34.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox34.Name = "pictureBox34";
            this.pictureBox34.Size = new System.Drawing.Size(100, 100);
            this.pictureBox34.TabIndex = 80;
            this.pictureBox34.TabStop = false;
            // 
            // pictureBox35
            // 
            this.pictureBox35.BackColor = System.Drawing.Color.Black;
            this.pictureBox35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox35.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox35.Image")));
            this.pictureBox35.Location = new System.Drawing.Point(600, 100);
            this.pictureBox35.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox35.Name = "pictureBox35";
            this.pictureBox35.Size = new System.Drawing.Size(100, 100);
            this.pictureBox35.TabIndex = 79;
            this.pictureBox35.TabStop = false;
            // 
            // pictureBox36
            // 
            this.pictureBox36.BackColor = System.Drawing.Color.Black;
            this.pictureBox36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox36.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox36.Image")));
            this.pictureBox36.Location = new System.Drawing.Point(600, 0);
            this.pictureBox36.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox36.Name = "pictureBox36";
            this.pictureBox36.Size = new System.Drawing.Size(100, 100);
            this.pictureBox36.TabIndex = 78;
            this.pictureBox36.TabStop = false;
            // 
            // pictureBox23
            // 
            this.pictureBox23.BackColor = System.Drawing.Color.Black;
            this.pictureBox23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox23.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox23.Image")));
            this.pictureBox23.Location = new System.Drawing.Point(500, 399);
            this.pictureBox23.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(100, 100);
            this.pictureBox23.TabIndex = 77;
            this.pictureBox23.TabStop = false;
            // 
            // pictureBox24
            // 
            this.pictureBox24.BackColor = System.Drawing.Color.Black;
            this.pictureBox24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox24.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox24.Image")));
            this.pictureBox24.Location = new System.Drawing.Point(500, 299);
            this.pictureBox24.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(100, 100);
            this.pictureBox24.TabIndex = 76;
            this.pictureBox24.TabStop = false;
            // 
            // pictureBox26
            // 
            this.pictureBox26.BackColor = System.Drawing.Color.Black;
            this.pictureBox26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox26.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox26.Image")));
            this.pictureBox26.Location = new System.Drawing.Point(500, 200);
            this.pictureBox26.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(100, 100);
            this.pictureBox26.TabIndex = 75;
            this.pictureBox26.TabStop = false;
            // 
            // pictureBox27
            // 
            this.pictureBox27.BackColor = System.Drawing.Color.Black;
            this.pictureBox27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox27.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox27.Image")));
            this.pictureBox27.Location = new System.Drawing.Point(500, 100);
            this.pictureBox27.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(100, 100);
            this.pictureBox27.TabIndex = 74;
            this.pictureBox27.TabStop = false;
            // 
            // pictureBox28
            // 
            this.pictureBox28.BackColor = System.Drawing.Color.Black;
            this.pictureBox28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox28.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox28.Image")));
            this.pictureBox28.Location = new System.Drawing.Point(500, 0);
            this.pictureBox28.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox28.Name = "pictureBox28";
            this.pictureBox28.Size = new System.Drawing.Size(100, 100);
            this.pictureBox28.TabIndex = 73;
            this.pictureBox28.TabStop = false;
            this.pictureBox28.Click += new System.EventHandler(this.pictureBox28_Click);
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackColor = System.Drawing.Color.Black;
            this.pictureBox16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
            this.pictureBox16.Location = new System.Drawing.Point(400, 399);
            this.pictureBox16.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(100, 100);
            this.pictureBox16.TabIndex = 72;
            this.pictureBox16.TabStop = false;
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackColor = System.Drawing.Color.Black;
            this.pictureBox18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox18.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox18.Image")));
            this.pictureBox18.Location = new System.Drawing.Point(400, 299);
            this.pictureBox18.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(100, 100);
            this.pictureBox18.TabIndex = 71;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackColor = System.Drawing.Color.Black;
            this.pictureBox19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox19.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox19.Image")));
            this.pictureBox19.Location = new System.Drawing.Point(400, 200);
            this.pictureBox19.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(100, 100);
            this.pictureBox19.TabIndex = 70;
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox20
            // 
            this.pictureBox20.BackColor = System.Drawing.Color.Black;
            this.pictureBox20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox20.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox20.Image")));
            this.pictureBox20.Location = new System.Drawing.Point(400, 100);
            this.pictureBox20.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(100, 100);
            this.pictureBox20.TabIndex = 69;
            this.pictureBox20.TabStop = false;
            // 
            // pictureBox21
            // 
            this.pictureBox21.BackColor = System.Drawing.Color.Black;
            this.pictureBox21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox21.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox21.Image")));
            this.pictureBox21.Location = new System.Drawing.Point(400, 0);
            this.pictureBox21.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(100, 100);
            this.pictureBox21.TabIndex = 68;
            this.pictureBox21.TabStop = false;
            this.pictureBox21.Click += new System.EventHandler(this.pictureBox21_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Black;
            this.pictureBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(300, 399);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(100, 100);
            this.pictureBox10.TabIndex = 67;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Black;
            this.pictureBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(300, 299);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(100, 100);
            this.pictureBox11.TabIndex = 66;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Black;
            this.pictureBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(300, 200);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(100, 100);
            this.pictureBox12.TabIndex = 65;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Black;
            this.pictureBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(300, 100);
            this.pictureBox13.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(100, 100);
            this.pictureBox13.TabIndex = 64;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.Black;
            this.pictureBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(300, 0);
            this.pictureBox14.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(100, 100);
            this.pictureBox14.TabIndex = 63;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Click += new System.EventHandler(this.pictureBox14_Click_2);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(200, 399);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 100);
            this.pictureBox4.TabIndex = 62;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Black;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(200, 299);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 100);
            this.pictureBox6.TabIndex = 61;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Black;
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(200, 200);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(100, 100);
            this.pictureBox7.TabIndex = 60;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Black;
            this.pictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(200, 100);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(100, 100);
            this.pictureBox8.TabIndex = 59;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Black;
            this.pictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(200, 0);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(100, 100);
            this.pictureBox9.TabIndex = 58;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click_1);
            // 
            // pictureBox30
            // 
            this.pictureBox30.BackColor = System.Drawing.Color.Black;
            this.pictureBox30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox30.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox30.Image")));
            this.pictureBox30.Location = new System.Drawing.Point(100, 399);
            this.pictureBox30.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox30.Name = "pictureBox30";
            this.pictureBox30.Size = new System.Drawing.Size(100, 100);
            this.pictureBox30.TabIndex = 57;
            this.pictureBox30.TabStop = false;
            // 
            // pictureBox29
            // 
            this.pictureBox29.BackColor = System.Drawing.Color.Black;
            this.pictureBox29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox29.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox29.Image")));
            this.pictureBox29.Location = new System.Drawing.Point(0, 399);
            this.pictureBox29.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox29.Name = "pictureBox29";
            this.pictureBox29.Size = new System.Drawing.Size(100, 100);
            this.pictureBox29.TabIndex = 56;
            this.pictureBox29.TabStop = false;
            this.pictureBox29.Click += new System.EventHandler(this.pictureBox29_Click);
            // 
            // pictureBox22
            // 
            this.pictureBox22.BackColor = System.Drawing.Color.Black;
            this.pictureBox22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox22.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox22.Image")));
            this.pictureBox22.Location = new System.Drawing.Point(100, 299);
            this.pictureBox22.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(100, 100);
            this.pictureBox22.TabIndex = 50;
            this.pictureBox22.TabStop = false;
            this.pictureBox22.Click += new System.EventHandler(this.pictureBox22_Click);
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.Black;
            this.pictureBox15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
            this.pictureBox15.Location = new System.Drawing.Point(100, 200);
            this.pictureBox15.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(100, 100);
            this.pictureBox15.TabIndex = 44;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Click += new System.EventHandler(this.pictureBox15_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Black;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(100, 100);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 100);
            this.pictureBox5.TabIndex = 34;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(100, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click_1);
            // 
            // pictureBox25
            // 
            this.pictureBox25.BackColor = System.Drawing.Color.Black;
            this.pictureBox25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox25.Location = new System.Drawing.Point(0, 299);
            this.pictureBox25.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(100, 100);
            this.pictureBox25.TabIndex = 24;
            this.pictureBox25.TabStop = false;
            this.pictureBox25.Click += new System.EventHandler(this.pictureBox25_Click);
            // 
            // pictureBox33
            // 
            this.pictureBox33.BackColor = System.Drawing.Color.Black;
            this.pictureBox33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox33.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox33.Image")));
            this.pictureBox33.Location = new System.Drawing.Point(0, 200);
            this.pictureBox33.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox33.Name = "pictureBox33";
            this.pictureBox33.Size = new System.Drawing.Size(100, 100);
            this.pictureBox33.TabIndex = 16;
            this.pictureBox33.TabStop = false;
            this.pictureBox33.Click += new System.EventHandler(this.pictureBox33_Click);
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = System.Drawing.Color.Black;
            this.pictureBox17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox17.Location = new System.Drawing.Point(0, 100);
            this.pictureBox17.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(100, 100);
            this.pictureBox17.TabIndex = 8;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.Click += new System.EventHandler(this.pictureBox17_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox73
            // 
            this.pictureBox73.Image = global::WindowsFormsApp1.Properties.Resources.Монстр11;
            this.pictureBox73.Location = new System.Drawing.Point(394, 49);
            this.pictureBox73.Name = "pictureBox73";
            this.pictureBox73.Size = new System.Drawing.Size(204, 424);
            this.pictureBox73.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox73.TabIndex = 33;
            this.pictureBox73.TabStop = false;
            this.pictureBox73.Click += new System.EventHandler(this.pictureBox73_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 457);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 719);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Adventure";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox66)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox67)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox68)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox69)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox70)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox71)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox72)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox59)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox60)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox61)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox62)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox63)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox64)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox65)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox53)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox54)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox55)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox56)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox57)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox58)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox49)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox73)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.RichTextBox richTextBox2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.PictureBox pictureBox2;
        internal System.Windows.Forms.PictureBox pictureBox17;
        internal System.Windows.Forms.PictureBox pictureBox33;
        internal System.Windows.Forms.PictureBox pictureBox25;
        internal System.Windows.Forms.PictureBox pictureBox3;
        internal System.Windows.Forms.PictureBox pictureBox5;
        internal System.Windows.Forms.PictureBox pictureBox15;
        internal System.Windows.Forms.PictureBox pictureBox22;
        internal System.Windows.Forms.PictureBox pictureBox29;
        internal System.Windows.Forms.PictureBox pictureBox30;
        internal System.Windows.Forms.Button button11;
        internal System.Windows.Forms.PictureBox pictureBox9;
        internal System.Windows.Forms.PictureBox pictureBox8;
        internal System.Windows.Forms.PictureBox pictureBox7;
        internal System.Windows.Forms.PictureBox pictureBox6;
        internal System.Windows.Forms.PictureBox pictureBox4;
        internal System.Windows.Forms.PictureBox pictureBox14;
        internal System.Windows.Forms.PictureBox pictureBox13;
        internal System.Windows.Forms.PictureBox pictureBox12;
        internal System.Windows.Forms.PictureBox pictureBox11;
        internal System.Windows.Forms.PictureBox pictureBox10;
        internal System.Windows.Forms.PictureBox pictureBox21;
        internal System.Windows.Forms.PictureBox pictureBox20;
        internal System.Windows.Forms.PictureBox pictureBox19;
        internal System.Windows.Forms.PictureBox pictureBox18;
        internal System.Windows.Forms.PictureBox pictureBox16;
        internal System.Windows.Forms.PictureBox pictureBox28;
        internal System.Windows.Forms.PictureBox pictureBox27;
        internal System.Windows.Forms.PictureBox pictureBox26;
        internal System.Windows.Forms.PictureBox pictureBox24;
        internal System.Windows.Forms.PictureBox pictureBox23;
        internal System.Windows.Forms.PictureBox pictureBox36;
        internal System.Windows.Forms.PictureBox pictureBox35;
        internal System.Windows.Forms.PictureBox pictureBox34;
        internal System.Windows.Forms.PictureBox pictureBox32;
        internal System.Windows.Forms.PictureBox pictureBox31;
        internal System.Windows.Forms.PictureBox pictureBox50;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Button button5;
        internal System.Windows.Forms.Button button7;
        public System.Windows.Forms.PictureBox pictureBox37;
        private System.Windows.Forms.Button button8;
        public System.Windows.Forms.PictureBox pictureBox39;
        public System.Windows.Forms.PictureBox pictureBox38;
        public System.Windows.Forms.PictureBox pictureBox66;
        public System.Windows.Forms.PictureBox pictureBox67;
        public System.Windows.Forms.PictureBox pictureBox68;
        public System.Windows.Forms.PictureBox pictureBox69;
        public System.Windows.Forms.PictureBox pictureBox70;
        public System.Windows.Forms.PictureBox pictureBox71;
        public System.Windows.Forms.PictureBox pictureBox72;
        public System.Windows.Forms.PictureBox pictureBox59;
        public System.Windows.Forms.PictureBox pictureBox60;
        public System.Windows.Forms.PictureBox pictureBox61;
        public System.Windows.Forms.PictureBox pictureBox62;
        public System.Windows.Forms.PictureBox pictureBox63;
        public System.Windows.Forms.PictureBox pictureBox64;
        public System.Windows.Forms.PictureBox pictureBox65;
        public System.Windows.Forms.PictureBox pictureBox52;
        public System.Windows.Forms.PictureBox pictureBox53;
        public System.Windows.Forms.PictureBox pictureBox54;
        public System.Windows.Forms.PictureBox pictureBox55;
        public System.Windows.Forms.PictureBox pictureBox56;
        public System.Windows.Forms.PictureBox pictureBox57;
        public System.Windows.Forms.PictureBox pictureBox58;
        public System.Windows.Forms.PictureBox pictureBox51;
        public System.Windows.Forms.PictureBox pictureBox49;
        public System.Windows.Forms.PictureBox pictureBox48;
        public System.Windows.Forms.PictureBox pictureBox47;
        public System.Windows.Forms.PictureBox pictureBox46;
        public System.Windows.Forms.PictureBox pictureBox45;
        public System.Windows.Forms.PictureBox pictureBox44;
        public System.Windows.Forms.PictureBox pictureBox43;
        public System.Windows.Forms.PictureBox pictureBox42;
        public System.Windows.Forms.PictureBox pictureBox41;
        public System.Windows.Forms.PictureBox pictureBox40;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox73;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}