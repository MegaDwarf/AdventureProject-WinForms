using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {


        public Form2()
        {
            InitializeComponent();
            tabPage2.Parent = null;
            button11.Visible = true;
            label12.Visible = false;
            listBox1.Visible = false;
            listBox2.Visible = false;
            richTextBox1.Visible = true;
            richTextBox2.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button7.Enabled = false;
            pictureBox37.Visible = true; GlobalData.coord[6] = 1;
            pictureBox38.Visible = true; GlobalData.coord[5] = 1;
            pictureBox39.Visible = false;
            pictureBox40.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox47.Visible = false;
            pictureBox48.Visible = false;
            pictureBox49.Visible = false;           
            pictureBox51.Visible = true; GlobalData.coord[13] = 1;
            pictureBox52.Visible = false;
            pictureBox53.Visible = false;
            pictureBox54.Visible = false;
            pictureBox55.Visible = false;
            pictureBox56.Visible = false;
            pictureBox57.Visible = false;
            pictureBox58.Visible = false;
            pictureBox59.Visible = false;
            pictureBox60.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox63.Visible = false;
            pictureBox64.Visible = false;
            pictureBox65.Visible = false;
            pictureBox66.Visible = false;
            pictureBox67.Visible = false;
            pictureBox68.Visible = false;
            pictureBox69.Visible = false;
            pictureBox70.Visible = false;
            pictureBox71.Visible = false;
            pictureBox72.Visible = false;
            listBox1.Items.Add("Великий божественный меч");
            listBox1.Items.Add("Старые доспехи рыцаря света");

            int[] coord = new int [45];
            showstats();


        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        public person Pendragon = new person( );
        public static person Monster = new person(/*имя*/"Monster",/*здоровье*/ 60,/*сила*/ 2,/*интелект*/ 1,/*ловкость*/ 1, /*харизма*/1,/*урон*/ 30,/*уровень*/ 1, /*количество*/1);
       // public person Monster2 = new person(/*имя*/"Грабитель",/*здоровье*/ 140,/*сила*/ 2,/*интелект*/ 1,/*ловкость*/ 1, /*харизма*/1,/*урон*/ 10,/*уровень*/ 1, 1);
        //public person Monster3 = new person(/*имя*/"Грабитель",/*здоровье*/ 80,/*сила*/ 2,/*интелект*/ 4,/*ловкость*/ 1, /*харизма*/1,/*урон*/ 15,/*уровень*/ 1, 1);
        
        
       /* item[] item_array = new item[4];
        public item defolt = new item("Старая крестьянская одежда", 0, 0, 0, 0, 0, 0, 1);
        public item sword = new item("Старый одноручный меч", 0, 1, 0, 0, 0, 15, 3);
        public item shield = new item("Старый щит", 10, 1, 0, 0, 0, 0, 3);*/
        //public item armor = new item(/*наименование одежды*/"Старые доспехи рыцаря света",/*характеристика здоровье+*/ 10,/*сила*/ 1, /*интелект*/ 0,/*ловкость*/ 0, /*харизма*/1, /*урон*/0, /*идентификатор*/4);


        private void button1_Click(object sender, EventArgs e)
        {
            
            //сие обеспечивает поиск по названию предметов экипировки
           // item_array[0] = defolt;//присваиваем объект элементу массива объектов
            //item_array[1] = sword;
           // item_array[2] = shield;
           // item_array[3] = armor;
            //for (int i = 0; i < item_array.Length; i++)//поиск по полю объекта
            //{
            //    if (item_array[i].name==listBox1.SelectedItem.ToString())
            //    {

            //        listBox2.Items.Add(listBox1.SelectedItem.ToString());
            //        Pendragon.health = item_array[i].health+ Pendragon.health;
            //        Pendragon.strengh = item_array[i].strengh+ Pendragon.strengh;
            //        Pendragon.inteligens = item_array[i].inteligens+Pendragon.inteligens;
            //        Pendragon.agility = item_array[i].agility + Pendragon.agility;
            //        Pendragon.charisma = item_array[i].charisma + Pendragon.charisma;
            //        Pendragon.damage = item_array[i].damage + Pendragon.damage;

            //        label1.Text = "Здоровье: " + Pendragon.health.ToString() + "\n"+"Сила:"+ Pendragon.strengh.ToString() + "\n" + "Интелект:"+ Pendragon.inteligens.ToString() + "\n" + "Ловкость:"+ Pendragon.agility.ToString() + "\n" + "Харизма: " + Pendragon.charisma.ToString() + "\n"+"Урон:"+ Pendragon.damage.ToString() + "\n";
            //    }
            //}

        }
       



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Pendragon.magic == true && Pendragon.mana>=80) { Pendragon.health = Pendragon.maxhealth; Pendragon.mana -= 80; }
            showstats();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {

        }

       

        

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (Form f2 in Application.OpenForms)
            {
                if (f2.Name == "Form3")//Another form with name "Form1" is already opened, but it is not Form1 instance, what should I do?
                {
                    MessageBox.Show("Уже открыта");
                    return;
                }
            }
            showstats();
            Form3 f3 = new Form3();
            f3.Owner = this;
            f3.Show();
        }

        public void label1_Click(object sender, EventArgs e)
        {
            
        }

        public void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
        
      

        

        

       

        

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox50_Click(object sender, EventArgs e)
        {
           // richTextBox1.Text = pictureBox50.Left.ToString() +"\n"+ pictureBox72.Left.ToString();
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
           
           // label1.Text = pictureBox33.Top.ToString()+'\n'+ pictureBox50.Top.ToString();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button11.Text == "Отмена перехода")
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button11.Text = "Перейти в локацию";
            }
            else
            
            
            {
                button1.Left = pictureBox50.Left - 75; button1.Top = pictureBox50.Top;
                button2.Top = pictureBox50.Top - 81; button2.Left = pictureBox50.Left;
                button3.Left = pictureBox50.Left + 75; button3.Top = pictureBox50.Top;
                button4.Top = pictureBox50.Top + 81; button4.Left = pictureBox50.Left;
                button11.Text = "Отмена перехода";
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
            }
            if (pictureBox50.Left == 0) { button1.Visible = false; }
            if (pictureBox50.Top == 0) { button2.Visible = false; }
            if (pictureBox50.Left == 450) { button3.Visible = false; }
            if (pictureBox50.Top == 324) { button4.Visible = false; }

            


            
            
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
          //  label1.Text = pictureBox17.Top.ToString() + '\n' + pictureBox50.Top.ToString();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        

      

       

      

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            
            //label1.Text = pictureBox22.Left.ToString()+'\n'+ pictureBox50.Left.ToString();
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            //label1.Text = pictureBox3.Left.ToString() + "left this" + '\n' + pictureBox50.Left.ToString() + "left char" + '\n'+ pictureBox3.Top.ToString() + "top this" + '\n' + pictureBox50.Top.ToString() + "top char";
            
           
        }

        private void pictureBox9_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox14_Click_2(object sender, EventArgs e)
        {
            
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            //label1.Text = pictureBox31.Left.ToString() + "left this" + '\n' + pictureBox50.Left.ToString() + "left char" + '\n' + pictureBox31.Top.ToString() + "top this" + '\n' + pictureBox50.Top.ToString() + "top char";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pictureBox50.Left -= 75;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button11.Text = "Перейти в локацию";
            Pendragon.movepoint -= 1;
            if (Pendragon.movepoint <= 0)
            {
                button11.Visible = false;
                button5.Visible = false;
                button7.Visible = false;

            }

            for (int i = 0; i < 35; i++)
            {


                if (GlobalData.coord[i] > 0 && pictureBox50.Left == 75 * (i % 7) && pictureBox50.Top == 81 * (i / 7)) { button7.Enabled = true; } 



            }






        }
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox50.Top -= 81;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button11.Text = "Перейти в локацию";
            Pendragon.movepoint -= 1;
            if (Pendragon.movepoint <= 0)
            {
                button11.Visible = false;
                button5.Visible = false;
                button7.Visible = false;

            }



            for (int i = 0; i < 35; i++)
            {


                if (GlobalData.coord[i] > 0 && pictureBox50.Left == 75 * (i % 7) && pictureBox50.Top == 81 * (i / 7)) { button7.Enabled = true; } 



            }


           /* for (int i = 0; i < 35; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        if (GlobalData.coord[i] > 0 && pictureBox50.Left == 75 * j && pictureBox50.Top == 81 * k) { button7.Enabled = true; }
                        
                    }
                }
            }*/



        }
        private void button3_Click(object sender, EventArgs e)
        {

            pictureBox50.Left += 75;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button11.Text = "Перейти в локацию";
            Pendragon.movepoint -= 1;
            if (Pendragon.movepoint <= 0)
            {
                button11.Visible = false;
                button5.Visible = false;
                button7.Visible = false;

            }

            
          
            //проверка готовности к бою
            for (int i = 0; i < 35; i++)
            {
                
                    
                if (GlobalData.coord[i] > 0 && pictureBox50.Left == 75 * (i%7) && pictureBox50.Top == 81 * (i/7)) { button7.Enabled = true; } 



            }

            



        }
        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox50.Top += 81;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button11.Text = "Перейти в локацию";
            Pendragon.movepoint -= 1;
            if (Pendragon.movepoint <= 0)
            {
                button11.Visible = false;
                button5.Visible = false;
                button7.Visible = false;

            }


            for (int i = 0; i < 35; i++)
            {
                

                    if ( GlobalData.coord[i] > 0 && pictureBox50.Left == 75 * (i % 7) && pictureBox50.Top == 81 * (i/7)) { button7.Enabled = true; }



            }



        }
        private void button7_Click(object sender, EventArgs e)
        {
            
            // Random rnd = new Random();
            // int rn = rnd.Next(-5, 5);
            //person Monsterr = new person(/*имя*/"Монстер",/*здоровье*/ 60,/*сила*/ 2,/*интелект*/ 1,/*ловкость*/ 1, /*харизма*/1,/*урон*/ 30,/*уровень*/ 1, /*количество*/1);
            Monster.count= generatemonsters();
            richTextBox2.Clear();
        
            Pendragon.movepoint -= 1;
            tabPage2.Parent = tabControl1;
            this.tabControl1.SelectedIndex = 1;
            button11.Enabled = false;
            button5.Enabled = false;

            button7.Enabled = false;
            label2.Text = "Здоровье монстра: " + Monster.health.ToString() + "\n Сила монстра: " + Monster.strengh.ToString() + "\n Интелект монстра: " + Monster.inteligens.ToString() + "\n Ловкость монстра: " + Monster.agility.ToString() + "\n Уровень монстра: " + Monster.level.ToString();


            /*foreach (Control c in tabControl1.TabPages)
            {

                c.Enabled = false;

            }*/








        }

        public static class GlobalData
        {
            public static int[] coord = new int[35];
           
        }
        public void button8_Click_1(object sender, EventArgs e)
        {
           
            //int[] coord = new int[35];

            Random rnd = new Random(); 

            int rndpoint = rnd.Next(0, 100);


             

            if (pictureBox37.Visible == false)
            {
                
                if (rndpoint == 1) { pictureBox37.Visible = true;

                    Random rnd1 = new Random();
                     GlobalData.coord[6] = rnd1.Next(1, 5); 
                }
            }
            if (pictureBox38.Visible == false)

            {

                if (rndpoint == 35) { pictureBox38.Visible = true;

                    Random rnd1 = new Random();
                    GlobalData.coord[5] = rnd1.Next(1, 5);
                }
            }

            if ( pictureBox39.Visible == false)
            {
                
                if (rndpoint == 2) { pictureBox39.Visible = true;

                    Random rnd1 = new Random();
                    GlobalData.coord[4] = rnd1.Next(1, 5);
                }
            }
            
            if (pictureBox40.Visible == false)
            {
                
                if (rndpoint == 3) { pictureBox40.Visible = true;


                    Random rnd1 = new Random();
                    GlobalData.coord[3] = rnd1.Next(1, 5);
                }
            }
            


            if (pictureBox41.Visible == false)
            {
                
                if (rndpoint == 4) { pictureBox41.Visible = true;


                    Random rnd1 = new Random();
                    GlobalData.coord[2] = rnd1.Next(1, 5);
                }
            }
            

            if (pictureBox42.Visible == false)
            {
                
                if (rndpoint == 5) { pictureBox42.Visible = true;

                    Random rnd1 = new Random();
                    GlobalData.coord[1] = rnd1.Next(1, 5);
                }


            }
            

            if (pictureBox43.Visible == false)
            {
                
                if (rndpoint == 6) { pictureBox43.Visible = true;

                    Random rnd1 = new Random();
                    GlobalData.coord[0]= rnd1.Next(1, 5); }
            }
            

            if (pictureBox44.Visible == false)
            {
                
                if (rndpoint == 7) { pictureBox44.Visible = true;

                    Random rnd1 = new Random();
                    GlobalData.coord[7] = rnd1.Next(1, 5);
                }
            }
            

            if (pictureBox45.Visible == false)
            {
                
                if (rndpoint == 8) { pictureBox45.Visible = true;

                    Random rnd1 = new Random();
                    GlobalData.coord[8] = rnd1.Next(1, 5);
                }
            }
            



            if (pictureBox46.Visible == false)
            {
               
                if (rndpoint == 9) { pictureBox46.Visible = true;

                    Random rnd1 = new Random();
                    GlobalData.coord[9] = rnd1.Next(1, 5);
                }
            }
            

            if (pictureBox47.Visible == false)
            {
                
                if (rndpoint == 10) { pictureBox47.Visible = true;

                    Random rnd1 = new Random();
                    GlobalData.coord[10] = rnd1.Next(1, 5);
                }
            }
            

            if (pictureBox48.Visible == false)
            {
                
                if (rndpoint == 11) { pictureBox48.Visible = true;

                    Random rnd1 = new Random();
                    GlobalData.coord[11] = rnd1.Next(1, 5);
                }
            }
            

            if (pictureBox49.Visible == false)
            {
                
                if (rndpoint == 12) { pictureBox49.Visible = true;

                    Random rnd1 = new Random();
                    GlobalData.coord[12] = rnd1.Next(1, 5);
                }
            }
            



            if (pictureBox51.Visible == false)
            {
                
                if (rndpoint == 13) { pictureBox51.Visible = true;

                    Random rnd1 = new Random();
                    GlobalData.coord[13] = rnd1.Next(1, 5);
                }
            }
            

            if (pictureBox52.Visible == false)
            {
                
                if (rndpoint == 14) { pictureBox52.Visible = true;

                    Random rnd1 = new Random();
                    GlobalData.coord[20] = rnd1.Next(1, 5);
                }
            }
            

            if (pictureBox53.Visible == false)
            {
                
                if (rndpoint == 15) { pictureBox53.Visible = true;

                    Random rnd1 = new Random();
                    GlobalData.coord[19] = rnd1.Next(1, 5);
                }
            }
            

            if (pictureBox54.Visible == false)
            {
                
                if (rndpoint == 16) { pictureBox54.Visible = true;

                    Random rnd1 = new Random();
                    GlobalData.coord[18] = rnd1.Next(1, 5);
                }
            }
            

            if (pictureBox55.Visible == false)
            {
                
                if (rndpoint == 17) { pictureBox55.Visible = true;

                    Random rnd1 = new Random();
                    GlobalData.coord[17] = rnd1.Next(1, 5);
                }
            }
            

            if (pictureBox56.Visible == false)
            {
                
                if (rndpoint == 18) { pictureBox56.Visible = true;

                    Random rnd1 = new Random();
                    GlobalData.coord[16] = rnd1.Next(1, 5);
                }
            }
            

            if (pictureBox57.Visible == false)
            {
                
                if (rndpoint == 19) { pictureBox57.Visible = true;

                    Random rnd1 = new Random();
                    GlobalData.coord[15] = rnd1.Next(1, 5);
                }
            }
            

            if (pictureBox58.Visible == false)
            {
                
                if (rndpoint == 20) { pictureBox58.Visible = true;

                    Random rnd1 = new Random();
                    GlobalData.coord[14] = rnd1.Next(1, 5);
                }
            }
            

            if (pictureBox59.Visible == false)
            {
                
                if (rndpoint == 21) { pictureBox59.Visible = true;

                    Random rnd1 = new Random();
                    GlobalData.coord[27] = rnd1.Next(1, 5);
                }
            }
            

            if (pictureBox60.Visible == false)
            {
                
                if (rndpoint == 22) { pictureBox60.Visible = true;

                    Random rnd1 = new Random();
                    GlobalData.coord[26] = rnd1.Next(1, 5);
                }
            }
            

            if (pictureBox61.Visible == false)
            {
                
                if (rndpoint == 23) { pictureBox61.Visible = true;

                    Random rnd1 = new Random();
                    GlobalData.coord[25] = rnd1.Next(1, 5);
                }
            }
            

            if (pictureBox62.Visible == false)
            {
                
                if (rndpoint == 24) { pictureBox62.Visible = true;

                    Random rnd1 = new Random();
                    GlobalData.coord[24] = rnd1.Next(1, 5);
                }
            }
            

            if (pictureBox63.Visible == false)
            {
                
                if (rndpoint == 25) { pictureBox63.Visible = true;

                    Random rnd1 = new Random();
                    GlobalData.coord[23] = rnd1.Next(1, 5);
                }
            }
            

            if (pictureBox64.Visible == false)
            {
                
                if (rndpoint == 26) { pictureBox64.Visible = true;

                    Random rnd1 = new Random();
                    GlobalData.coord[22] = rnd1.Next(1, 5);
                }
            }
            

            if (pictureBox65.Visible == false)
            {
                
                if (rndpoint == 27) { pictureBox65.Visible = true;

                    Random rnd1 = new Random();
                    GlobalData.coord[21] = rnd1.Next(1, 5);
                }
            }
            

            if (pictureBox66.Visible == false)
            {
                
                if (rndpoint == 28) { pictureBox66.Visible = true;

                    Random rnd1 = new Random();
                    GlobalData.coord[34] = rnd1.Next(1, 5);
                }
            }
            

            if (pictureBox67.Visible == false)
            {
                
                if (rndpoint == 29) { pictureBox67.Visible = true;

                    Random rnd1 = new Random();
                    GlobalData.coord[33] = rnd1.Next(1, 5);
                }
            }
            

            if (pictureBox68.Visible == false)
            {
                
                if (rndpoint == 30) { pictureBox68.Visible = true;

                    Random rnd1 = new Random();
                    GlobalData.coord[32] = rnd1.Next(1, 5);
                }
            }
            

            if (pictureBox69.Visible == false)
            {
                
                if (rndpoint == 31) { pictureBox69.Visible = true;

                    Random rnd1 = new Random();
                    GlobalData.coord[31] = rnd1.Next(1, 5);
                }
            }
            

            if (pictureBox70.Visible == false)
            {
                
                if (rndpoint == 32) { pictureBox70.Visible = true;

                    Random rnd1 = new Random();
                    GlobalData.coord[30] = rnd1.Next(1, 5);
                }
            }
            


            if (pictureBox71.Visible == false)
            {
                
                if (rndpoint == 33) { pictureBox71.Visible = true;

                    Random rnd1 = new Random();
                    GlobalData.coord[29] = rnd1.Next(1, 5);
                }
            }
            

            if (pictureBox72.Visible == false)
            {
                
                if (rndpoint == 34) { pictureBox72.Visible = true;

                    Random rnd1 = new Random();
                    GlobalData.coord[28] = rnd1.Next(1, 5);
                }
            }

            button11.Visible = true;
            button5.Visible = true;
            button7.Visible = true;
            Pendragon.movepoint = 2;
                
            
            




        }

        private void pictureBox44_Click(object sender, EventArgs e)
        {
            label1.Text = "top =" + pictureBox44.Top.ToString();
        }

        private void pictureBox43_Click(object sender, EventArgs e)
        {
            label1.Text ="left ="+ pictureBox43.Left.ToString()+"  top ="+ pictureBox43.Top.ToString();


        }

        private void pictureBox42_Click(object sender, EventArgs e)
        {
            label1.Text = "left =" + pictureBox42.Left.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Великий божественный меч");
            button9.Enabled = false;
            button9.Visible = false;
        }

        PictureBox[] pictureBoxes_array = new PictureBox[35];//массив объектов ура! сунуть в этот массив картинки и проверять picbox.left , если равно, то скрывать


        private void button12_Click(object sender, EventArgs e)
        {
            Pendragon.wepon = true;
            Pendragon.magic = false;
    }

        private void pictureBox73_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Monster.count.ToString() + "\n";
            if (Pendragon.wepon == true)
                {
                Random a = new Random();
                Monster.health = Monster.health - (Pendragon.damage + Pendragon.strengh * 5 - Monster.agility*5) + a.Next(-Pendragon.damage / 2, +Pendragon.damage/ 2); 
                richTextBox2.Text= "\n Герой: нанес " + ((Pendragon.damage + Pendragon.strengh * 5) + a.Next(-Pendragon.damage / 2, +Pendragon.damage / 2)).ToString()+ "\n"+ richTextBox2.Text ;
                label2.Text = "Здоровье монстра: " + Monster.health.ToString() + "\n Сила монстра: " + Monster.strengh.ToString() + "\n Интелект монстра: " + Monster.inteligens.ToString() + "\n Ловкость монстра: " + Monster.agility.ToString() + "\n Уровень монстра: " + Monster.level.ToString();
                showstats();
                if (Monster.health > 0)
                {
                    Pendragon.health = Pendragon.health - (Monster.damage - Pendragon.agility) + a.Next(-Monster.damage / 2, +Monster.damage / 2);
                    richTextBox2.Text = "\n Монстр: нанес " + ((Monster.damage - Pendragon.agility) + a.Next(-Monster.damage / 2, +Monster.damage / 2)).ToString() + richTextBox2.Text + "\n";
                    if ((Pendragon.mana + 10) > Pendragon.maxmana) { Pendragon.mana = Pendragon.maxmana; } else Pendragon.mana += 10;
                    showstats();
                    label2.Text = "Здоровье монстра: " + Monster.health.ToString() + "\n Сила монстра: " + Monster.strengh.ToString() + "\n Интелект монстра: " + Monster.inteligens.ToString() + "\n Ловкость монстра: " + Monster.agility.ToString() + "\n Уровень монстра: " + Monster.level.ToString();
                    if (death() == true) MessageBox.Show("Вы потерпели поражение в битве, но на в войне! \n Вы возродились в начальной локации, но ваши навыки немного уменьшились");
                }
            }
            if (Pendragon.magic == true)
            {
                Pendragon.mana -= 20;
                Random a = new Random();
                Monster.health = Monster.health - (Pendragon.damage + Pendragon.inteligens * 5 - Monster.agility - Monster.inteligens*5) + a.Next(-Pendragon.inteligens * 5, +Pendragon.inteligens * 5);
                richTextBox2.Text = "\n Герой: нанес " + ((Pendragon.damage + Pendragon.inteligens * 5 - Monster.agility - Monster.inteligens * 5) + a.Next(-Pendragon.inteligens * 5, +Pendragon.inteligens * 5)).ToString() + "\n" + richTextBox2.Text;
                showstats();

                label2.Text = "Здоровье монстра: " + Monster.health.ToString() + "\n Сила монстра: " + Monster.strengh.ToString() + "\n Интелект монстра: " + Monster.inteligens.ToString() + "\n Ловкость монстра: " + Monster.agility.ToString() + "\n Уровень монстра: " + Monster.level.ToString();
                if (Monster.health > 0)
                {
                    Pendragon.health = Pendragon.health - (Monster.damage - Pendragon.agility) + a.Next(-Monster.damage / 2, +Monster.damage / 2);
                    richTextBox2.Text = "\n Монстр: нанес " + ((Monster.damage - Pendragon.agility) + a.Next(-Monster.damage / 2, +Monster.damage / 2)).ToString() + richTextBox2.Text + "\n";

                    showstats();

                    label2.Text = "Здоровье монстра: " + Monster.health.ToString() + "\n Сила монстра: " + Monster.strengh.ToString() + "\n Интелект монстра: " + Monster.inteligens.ToString() + "\n Ловкость монстра: " + Monster.agility.ToString() + "\n Уровень монстра: " + Monster.level.ToString();
                    if (death() == true) MessageBox.Show("Вы потерпели поражение в битве, но на в войне! \n Вы возродились в начальной локации, но ваши навыки немного уменьшились");
                }
            }

            if (Monster.health <= 0)
            { Monster.count-=1;

                switch (Monster.count+1)
                {

                    case 8: this.label11.Text += "(Мертв)"; Pendragon.exp += 20; richTextBox2.Text = "\n получено 20 опыта" + richTextBox2.Text ;  richTextBox2.Text = "Монстр повержен!\n"+ richTextBox2.Text;
                        break;
                    case 7:
                        this.label10.Text += "(Мертв)"; Pendragon.exp += 20; richTextBox2.Text = "\n получено 20 опыта" + richTextBox2.Text ;  richTextBox2.Text = "Монстр повержен!\n" + richTextBox2.Text;
                        break;
                    case 6:
                        this.label9.Text += "(Мертв)"; Pendragon.exp += 20; richTextBox2.Text = "\n получено 20 опыта" + richTextBox2.Text ;  richTextBox2.Text = "Монстр повержен!\n" + richTextBox2.Text;
                        break;
                    case 5:
                        this.label8.Text += "(Мертв)"; Pendragon.exp += 20; richTextBox2.Text = "\n получено 20 опыта" + richTextBox2.Text ;  richTextBox2.Text = "Монстр повержен!\n" + richTextBox2.Text;
                        break;
                    case 4:
                        this.label7.Text += "(Мертв)"; Pendragon.exp += 20; richTextBox2.Text = "\n получено 20 опыта" + richTextBox2.Text;  richTextBox2.Text = "Монстр повержен!\n" + richTextBox2.Text;
                        break;
                    case 3:
                         this.label6.Text += "(Мертв)"; Pendragon.exp += 20; richTextBox2.Text = "\n получено 20 опыта" + richTextBox2.Text;  richTextBox2.Text = "Монстр повержен!\n" + richTextBox2.Text;
                        break;
                    case 2:
                        this.label5.Text += "(Мертв)"; Pendragon.exp += 20; richTextBox2.Text = "\n получено 20 опыта"+ richTextBox2.Text;  richTextBox2.Text = "Монстр повержен!\n" + richTextBox2.Text;
                        break;
                    case 1:
                        if (pictureBox36.Location != pictureBox50.Location)
                        {
                            this.label4.Text += "(Мертв)"; Pendragon.exp += 40; richTextBox2.Text = "\n получено 20 опыта" + richTextBox2.Text;  richTextBox2.Text = "Монстр повержен!\n" + richTextBox2.Text;
                            MessageBox.Show("Победа!");
                            picmass();
                            for (int i = 0; i < 35; i++)
                            {

                                if (pictureBoxes_array[i].Left == pictureBox50.Left + 45) { pictureBoxes_array[i].Visible = false; }

                            }
                            this.tabControl1.SelectedIndex = 0;
                            tabPage2.Parent = null;//эта крутая штука прячет табпэйдж путем присваивания пэрента нулл
                            showstats();
                            button11.Enabled = true;
                            button5.Enabled = true;
                            fightchek();
                        }
                        
                        label4.Text = "Зловещий портал"; label5.Text = "Монстр"; label6.Text = "Монстр"; label7.Text = "Монстр"; label8.Text = "Монстр";label9.Text = "Монстр"; label10.Text = "Монстр"; label11.Text = "Монстр";
                        break;
                    

                    
                }
                Random a = new Random();
                int k = a.Next(1, 4);
                if (k == 1)
                {

                    Monster.level = generatemonlvl();
                    Monster.health = 50 + Monster.level * 10;
                    Monster.inteligens = Monster.level;
                    Monster.damage = 2 * Monster.level + Monster.inteligens * 2;
                    Monster.strengh = 0;
                }
                else if(k==2)
                {
                    Monster.level = generatemonlvl();
                    Monster.health = 50 + Monster.level * 20;
                    Monster.strengh = Monster.level;
                    Monster.inteligens = 0;
                    Monster.damage = 2 * Monster.level + Monster.strengh*3;

                }
                else if(k==3)
                {
                    Monster.level = generatemonlvl();
                    Monster.health = 50 + Monster.level * 30;
                    Monster.strengh = Monster.level/2;
                    Monster.inteligens = 0;
                    Monster.agility = Monster.level;
                    Monster.damage = 2 * Monster.level + Monster.strengh * 2;


                }

                if (Monster.count == 1)
                {
                    pictureBox73.Image = WindowsFormsApp1.Properties.Resources.Портал11;
                    Monster.level = generatemonlvl();
                    Monster.health = 100 + Monster.level * 10;
                    Monster.inteligens = Monster.level;
                    Monster.damage = 2 * Monster.level + Monster.inteligens * 2 + Monster.strengh;
                    Monster.strengh = Monster.level/2;


                }
                if (pictureBox36.Location == pictureBox50.Location)
                {



                    if (Monster.count == 0)
                    {
                        label12.Visible = true;
                        richTextBox2.Text = "Перед вами появляется " + label12.Text + " \n";
                        Monster.level = 50;
                        Monster.health = 1000 + Monster.level * 10;
                        Monster.inteligens = Monster.level;
                        Monster.damage = 2 * Monster.level + Monster.inteligens * 2 + Monster.strengh;
                        Monster.strengh = Monster.level / 2;

                    }
                    else if (Monster.count < 0)
                    {
                        this.label4.Text += "(Мертв)"; Pendragon.exp += 100000000; richTextBox2.Text = "\n получено 100000000 опыта" + richTextBox2.Text;
                        MessageBox.Show("Победа!");
                        picmass();
                        for (int i = 0; i < 35; i++)
                        {

                            if (pictureBoxes_array[i].Left == pictureBox50.Left + 45) { pictureBoxes_array[i].Visible = false; }

                        }
                        this.tabControl1.SelectedIndex = 0;
                        tabPage2.Parent = null;//эта крутая штука прячет табпэйдж путем присваивания пэрента нулл
                        showstats();
                        button11.Enabled = true;
                        button5.Enabled = true;
                        fightchek();
                        MessageBox.Show("Поздравляем! \n Вы избавили мир от ужасного Повелителя монстров, после его гибели все чудовища превратились в пыль и улетучились. \n Весь этот чудесный мир благодарен вам!");

                    }
                }
                label2.Text = "Здоровье монстра: " + Monster.health.ToString()+"\n Сила монстра: "+Monster.strengh.ToString()+"\n Интелект монстра: "+Monster.inteligens.ToString()+"\n Ловкость монстра: "+Monster.agility.ToString()+"\n Уровень монстра: "+Monster.level.ToString()+"\n Type "+ k.ToString();



            }
           







        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Pendragon.magic = true;
            Pendragon.wepon = false;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

  
    }
}
