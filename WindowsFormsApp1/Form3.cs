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
    
    public partial class Form3 : Form
    {
        
        public Label label1;
        public Form3()
        {
            
            InitializeComponent();
            
            this.FormClosing += new FormClosingEventHandler(Form3_FormClosing);//подписываемся на событие закрытия формы

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form2 f2 = this.Owner as Form2;
            if(listBox2.Items.Count!=0) for (int i = 0; i < listBox2.Items.Count; i++) { f2.listBox2.Items.Insert(i, listBox2.Items[i]); }
            if (listBox1.Items.Count != 0) for (int i = 0; i < listBox1.Items.Count; i++) { f2.listBox1.Items.Insert(i, listBox1.Items[i]); }            
            f2.showstats();
        }



        /*string head = " ";
        string chest = " ";
        string legs = " ";
        string feet = " ";
        string leftarm = " ";
        string rightarm = "";
        string neck = " ";
        string trinket = " ";
        */

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Form2 f2 = this.Owner as Form2;
            f2.showstats();

        }

        //экземпляры оружия и брони
        item[] item_array = new item[5]; //кол-во всех предметов в игре
        public item defolt = new item("Старая крестьянская одежда", 0, 0, 0, 0, 0, 0, false,false,true);
        public item sword = new item("Старый одноручный меч", 0, 1, 0, 0, 0, 15,true,true,false);
        public item shield = new item("Старый щит", 10, 1, 0, 0, 0, 0,true,false,false);
        public item armor = new item(/*наименование одежды*/"Старые доспехи рыцаря света",/*характеристика здоровье+*/ 20,/*сила*/ 1, /*интелект*/ 0,/*ловкость*/ 0, /*харизма*/1, /*урон*/0, /*левая рука*/false,/*правая рука*/false,/*тело*/true);
        public item greatsword = new item("Великий божественный меч", 50, 5, 0, 0, 0, 49, true, true, false);


        public void button1_Click(object sender, EventArgs e)
        {
            
            Form2 f2 = this.Owner as Form2;

                item_array[0] = defolt;//присваиваем объект элементу массива объектов
                item_array[1] = sword;
                item_array[2] = shield;
                item_array[3] = armor;
                item_array[4] = greatsword;

               
            if (button1.Text == "Надеть предмет")
            {
                
                
                for (int i = 0; i < item_array.Length; i++)//поиск по полю объекта
                {
                    if (item_array[i].name == listBox1.SelectedItem.ToString()  &&(((item_array[i].lhand ==true) && (f2.Pendragon.lhand == false))|| (item_array[i].rhand == true && f2.Pendragon.rhand == false) || (item_array[i].body == true && f2.Pendragon.body == false)))
                    {
                        
                        
                            listBox2.Items.Add(listBox1.SelectedItem.ToString());
                            f2.Pendragon.health = item_array[i].health + f2.Pendragon.health;
                            f2.Pendragon.maxhealth = item_array[i].health + f2.Pendragon.maxhealth;
                            f2.Pendragon.strengh = item_array[i].strengh + f2.Pendragon.strengh;
                            f2.Pendragon.inteligens = item_array[i].inteligens + f2.Pendragon.inteligens;
                            f2.Pendragon.agility = item_array[i].agility + f2.Pendragon.agility;
                            f2.Pendragon.charisma = item_array[i].charisma + f2.Pendragon.charisma;
                            f2.Pendragon.damage = item_array[i].damage + f2.Pendragon.damage;
                       
                        label2.Text = "Здоровье: "+ f2.Pendragon.health.ToString()+"/" + f2.Pendragon.maxhealth.ToString() + "\n" + "Сила:" + f2.Pendragon.strengh.ToString() + "\n" + "Интелект:" + f2.Pendragon.inteligens.ToString() + "\n" + "Ловкость:" + f2.Pendragon.agility.ToString() + "\n" + "Харизма: " + f2.Pendragon.charisma.ToString() + "\n" + "Урон:" + f2.Pendragon.damage.ToString() + "\n";

                        if ((item_array[i].rhand == true) && (f2.Pendragon.rhand == false))
                        {
                            f2.Pendragon.rhand = true;
                        }
                        else if (item_array[i].lhand == true && f2.Pendragon.lhand == false)
                        {
                            f2.Pendragon.lhand = true;
                        }
                        if (item_array[i].body == true && f2.Pendragon.body == false)
                        {
                            f2.Pendragon.body = true;
                        }
                        listBox1.Items.RemoveAt(listBox1.SelectedIndex);i = item_array.Length;

                    }


                }


                //listBox2.Items.Add(listBox1.SelectedItem.ToString()); 

                //if (listBox1.SelectedItem.ToString() == "Мятая майка")
                //{
                //    f2.Pendragon.charisma = f2.charisma + 1;
                //    f2.label1.Text = "Здоровье: " + f2.Pendragon.health.ToString() + "\n" + "Харизма: " + f2.Pendragon.charisma.ToString() + "\n";
                //}                



                 
            }



            if (button1.Text == "Снять предмет")
            {



                for (int i = 0; i < item_array.Length; i++)//поиск по полю объекта
                {
                    if (item_array[i].name == listBox2.SelectedItem.ToString())
                    {

                        listBox1.Items.Add(listBox2.SelectedItem.ToString());
                        f2.Pendragon.maxhealth = f2.Pendragon.maxhealth - item_array[i].health;
                        if(f2.Pendragon.health<= item_array[i].health) { f2.Pendragon.health = 1; } else { f2.Pendragon.health = f2.Pendragon.health - item_array[i].health; }
                        f2.Pendragon.strengh = f2.Pendragon.strengh - item_array[i].strengh;
                        f2.Pendragon.inteligens = f2.Pendragon.inteligens - item_array[i].inteligens;
                        f2.Pendragon.agility = f2.Pendragon.agility - item_array[i].agility;
                        f2.Pendragon.charisma = f2.Pendragon.charisma - item_array[i].charisma;
                        f2.Pendragon.damage = f2.Pendragon.damage - item_array[i].damage;

                        label2.Text = "Здоровье: " + f2.Pendragon.health.ToString() + "/" + f2.Pendragon.maxhealth.ToString() + "\n" + "Сила:" + f2.Pendragon.strengh.ToString() + "\n" + "Интелект:" + f2.Pendragon.inteligens.ToString() + "\n" + "Ловкость:" + f2.Pendragon.agility.ToString() + "\n" + "Харизма: " + f2.Pendragon.charisma.ToString() + "\n" + "Урон:" + f2.Pendragon.damage.ToString() + "\n";

                        if ((item_array[i].rhand == true) && (f2.Pendragon.rhand == true))
                        {
                            f2.Pendragon.rhand = false;
                        }
                        else if (item_array[i].lhand == true && f2.Pendragon.lhand == true)
                        {
                            f2.Pendragon.lhand = false;
                        }
                        if (item_array[i].body == true && f2.Pendragon.body == true)
                        {
                            f2.Pendragon.body = false;
                        }
                        listBox2.Items.RemoveAt(listBox2.SelectedIndex); i = item_array.Length;

                    }


                }


                //listBox1.Items.Add(listBox2.SelectedItem.ToString());


                //if (listBox2.SelectedItem.ToString() == "Мятая майка")
                //{
                //    f2.charisma = f2.charisma - 1;
                //    f2.label1.Text = "Здоровье: " + f2.Pendragon.health.ToString() + "\n" + "Харизма: " + f2.Pendragon.charisma.ToString() + "\n";
                //}



               // listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }

            
           //--------  хотябы дописать сценарий первого квеста, возможно начать прописывать его в коде

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            button1.Text = "Надеть предмет";

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Text = "Снять предмет";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            showstats();
            Form2 f2 = this.Owner as Form2;
            if(f2.listBox2.Items.Count!=0)for(int i = 0; i < f2.listBox2.Items.Count; i++) { listBox2.Items.Insert(i, f2.listBox2.Items[i]); }
            if (f2.listBox1.Items.Count != 0) for (int i = 0; i < f2.listBox1.Items.Count; i++) { listBox1.Items.Insert(i, f2.listBox1.Items[i]); }
            f2.listBox1.Items.Clear();
            f2.listBox2.Items.Clear();
            f2.showstats();
            label4.Text += " " + f2.Pendragon.maxhealth.ToString();
            label5.Text += " " + f2.Pendragon.maxmana.ToString();
            label6.Text += " " + f2.Pendragon.strengh.ToString();
            label7.Text += " " + f2.Pendragon.inteligens.ToString();
            label8.Text += " " + f2.Pendragon.agility.ToString();
            label9.Text += " " + f2.Pendragon.charisma.ToString();
        }
        public void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = this.Owner as Form2;
            if (f2.Pendragon.exp >= 30)
            {
                f2.Pendragon.maxhealth += 10;
                label4.Text = "Здоровье " + f2.Pendragon.maxhealth.ToString();
                f2.Pendragon.exp -= 30;
                showstats();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = this.Owner as Form2;
            if (f2.Pendragon.exp >= 30)
            {
                f2.Pendragon.maxmana += 10;
                label5.Text = "Мана " + f2.Pendragon.maxmana.ToString();
                f2.Pendragon.exp -= 30;
                showstats();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f2 = this.Owner as Form2;
            if (f2.Pendragon.exp >= 30)
            {
                f2.Pendragon.strengh += 1;
                label6.Text = "Сила " + f2.Pendragon.strengh.ToString();
                f2.Pendragon.exp -= 30;
                showstats();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f2 = this.Owner as Form2;
            if (f2.Pendragon.exp >= 30)
            {
                f2.Pendragon.inteligens += 1;
                label7.Text = "Интелект " + f2.Pendragon.inteligens.ToString();
                f2.Pendragon.exp -= 30;
                showstats();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 f2 = this.Owner as Form2;
            if (f2.Pendragon.exp >= 30)
            {
                f2.Pendragon.agility += 1;
                label8.Text = "Ловкость " + f2.Pendragon.agility.ToString();
                f2.Pendragon.exp -= 30;
                showstats();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 f2 = this.Owner as Form2;
            if (f2.Pendragon.exp >= 30)
            {
                f2.Pendragon.charisma += 1;
                label9.Text = "Харизма "+ f2.Pendragon.charisma.ToString()+"\n(пока не нужна) " ;
                f2.Pendragon.exp -= 30;
                showstats();
            }
        }
    }
   
}
