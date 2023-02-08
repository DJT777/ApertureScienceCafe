using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        double coffeeTotal = 2.00;
        double pastryTotal = 0.00;
        double teaTotal = 2.00;
        double total = 0.00;

        public Form1()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }



        private void coffeeAddItem_Click(object sender, EventArgs e)
        {
            
            listViewOrder.Items.Add(new ListViewItem(new string[] {"Coffee", "$2.00"}));
            if (checkBoxCoffeeCream.Checked == true)
            {
                listViewOrder.Items.Add(new ListViewItem(new string[] { "Cream", "$0.00" }));
            };
            if (checkBoxCoffeeSugar.Checked == true)
            {
                listViewOrder.Items.Add(new ListViewItem(new string[] { "Sugar", "$0.00" }));
            }
            if (checkBoxCoffeeCinammon.Checked == true)
            {
                listViewOrder.Items.Add(new ListViewItem(new string[] { "Cinammon", "$0.75" }));
            }
            if (checkBoxCoffeeCocoa.Checked == true)
            {
                listViewOrder.Items.Add(new ListViewItem(new string[] { "Cocoa", "$0.50" }));
            }
            if (checkBoxCoffeeWhippedCream.Checked == true)
            {
                listViewOrder.Items.Add(new ListViewItem(new string[] { "Whipped Cream", "$0.75" }));
            }



            total += coffeeTotal;
            checkBoxCoffeeCream.Checked = false;
            checkBoxCoffeeSugar.Checked = false;
            checkBoxCoffeeCinammon.Checked = false;
            checkBoxCoffeeCocoa.Checked = false;
            checkBoxCoffeeCream.Checked = false;
            checkBoxCoffeeWhippedCream.Checked = false;            
            labelTotalAmount.Text = String.Format("{0:C2}", total);
            coffeeTotal = 2.00;
            textBoxCofeeTotal.Text = String.Format("{0:C2}", coffeeTotal);


        }

        private void listViewOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxCoffeeCinammon_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxCoffeeCinammon.Checked == true)
            {
                coffeeTotal += 0.75;
                textBoxCofeeTotal.Text = String.Format("{0:C2}", coffeeTotal);
            }

            if (checkBoxCoffeeCinammon.Checked == false)
            {
                coffeeTotal -= 0.75;
                textBoxCofeeTotal.Text = String.Format("{0:C2}", coffeeTotal);
            }
        }

        private void checkBoxCoffeeCocoa_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCoffeeCocoa.Checked == true)
            {
                coffeeTotal += 0.50;
                textBoxCofeeTotal.Text = String.Format("{0:C2}", coffeeTotal);
            }

            if (checkBoxCoffeeCocoa.Checked == false)
            {
                coffeeTotal -= 0.50;
                textBoxCofeeTotal.Text = String.Format("{0:C2}", coffeeTotal);
            }
        }

        private void checkBoxCoffeeWhippedCream_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCoffeeWhippedCream.Checked == true)
            {
                coffeeTotal += 0.75;
                textBoxCofeeTotal.Text = String.Format("{0:C2}", coffeeTotal);
            }

            if (checkBoxCoffeeWhippedCream.Checked == false)
            {
                coffeeTotal -= 0.75;
                textBoxCofeeTotal.Text = String.Format("{0:C2}", coffeeTotal);
            }
        }

        private void buttonPastriesAdd_Click(object sender, EventArgs e)
        {
            if (checkBoxVanilla.Checked == true)
            {
                listViewOrder.Items.Add(new ListViewItem(new string[] { "Vanilla Cake", "$2.00" }));
            };
            if (checkBoxChocolate.Checked == true)
            {
                listViewOrder.Items.Add(new ListViewItem(new string[] { "Chocolate Cake", "$2.00" }));
            }
            if (checkBoxStrawberry.Checked == true)
            {
                listViewOrder.Items.Add(new ListViewItem(new string[] { "Strawberry Cake", "$2.00" }));
            }
            if (checkBoxPound.Checked == true)
            {
                listViewOrder.Items.Add(new ListViewItem(new string[] { "Pound Cake", "$2.00" }));
            }
            if (checkBoxIcecream.Checked == true)
            {
                listViewOrder.Items.Add(new ListViewItem(new string[] { "Icecream Cake", "$2.00" }));
            }
            if (checkBoxLemon.Checked == true)
            {
                listViewOrder.Items.Add(new ListViewItem(new string[] { "Lemon Cake", "$2.00" }));
            }
            if (checkBoxPan.Checked == true)
            {
                listViewOrder.Items.Add(new ListViewItem(new string[] { "Pan Cake", "$2.00" }));
            }
            if (checkBoxDFood.Checked == true)
            {
                listViewOrder.Items.Add(new ListViewItem(new string[] { "D. Food Cake", "$2.00" }));
            }
            if (checkBoxAFood.Checked == true)
            {
                listViewOrder.Items.Add(new ListViewItem(new string[] { "A. Food Cake", "$2.00" }));
            }
            if (checkBoxCheese.Checked == true)
            {
                listViewOrder.Items.Add(new ListViewItem(new string[] { "Cheese Cake", "$2.00" }));
            }

            total += pastryTotal;
            labelTotalAmount.Text = String.Format("{0:C2}", total);

            checkBoxVanilla.Checked = false;
            checkBoxChocolate.Checked = false;
            checkBoxStrawberry.Checked = false;
            checkBoxPound.Checked = false;
            checkBoxLemon.Checked = false;
            checkBoxIcecream.Checked = false;
            checkBoxPan.Checked = false;
            checkBoxDFood.Checked = false;
            checkBoxAFood.Checked = false;
            checkBoxCheese.Checked = false;

            pastryTotal = 0.0;
            textBoxPastryTotal.Text = String.Format("{0:C2}", pastryTotal);

        }

        private void checkBoxVanilla_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxVanilla.Checked == true)
            {
                pastryTotal += 2.00;
                textBoxPastryTotal.Text = String.Format("{0:C2}", pastryTotal);
            }

            if (checkBoxVanilla.Checked == false)
            {
                pastryTotal -= 2.00;
                textBoxPastryTotal.Text = String.Format("{0:C2}", pastryTotal);
            }
        }

        private void checkBoxChocolate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxChocolate.Checked == true)
            {
                pastryTotal += 2.00;
                textBoxPastryTotal.Text = String.Format("{0:C2}", pastryTotal);
            }

            if (checkBoxChocolate.Checked == false)
            {
                pastryTotal -= 2.00;
                textBoxPastryTotal.Text = String.Format("{0:C2}", pastryTotal);
            }
        }

        private void checkBoxStrawberry_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStrawberry.Checked == true)
            {
                pastryTotal += 2.00;
                textBoxPastryTotal.Text = String.Format("{0:C2}", pastryTotal);
            }

            if (checkBoxStrawberry.Checked == false)
            {
                pastryTotal -= 2.00;
                textBoxPastryTotal.Text = String.Format("{0:C2}", pastryTotal);
            }

        }

        private void checkBoxPound_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPound.Checked == true)
            {
                pastryTotal += 2.00;
                textBoxPastryTotal.Text = String.Format("{0:C2}", pastryTotal);
            }

            if (checkBoxPound.Checked == false)
            {
                pastryTotal -= 2.00;
                textBoxPastryTotal.Text = String.Format("{0:C2}", pastryTotal);
            }
        }

        private void checkBoxLemon_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLemon.Checked == true)
            {
                pastryTotal += 2.00;
                textBoxPastryTotal.Text = String.Format("{0:C2}", pastryTotal);
            }

            if (checkBoxLemon.Checked == false)
            {
                pastryTotal -= 2.00;
                textBoxPastryTotal.Text = String.Format("{0:C2}", pastryTotal);
            }
        }

        private void checkBoxIcecream_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIcecream.Checked == true)
            {
                pastryTotal += 2.00;
                textBoxPastryTotal.Text = String.Format("{0:C2}", pastryTotal);
            }

            if (checkBoxIcecream.Checked == false)
            {
                pastryTotal -= 2.00;
                textBoxPastryTotal.Text = String.Format("{0:C2}", pastryTotal);
            }
        }

        private void checkBoxPan_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPan.Checked == true)
            {
                pastryTotal += 2.00;
                textBoxPastryTotal.Text = String.Format("{0:C2}", pastryTotal);
            }

            if (checkBoxPan.Checked == false)
            {
                pastryTotal -= 2.00;
                textBoxPastryTotal.Text = String.Format("{0:C2}", pastryTotal);
            }
        }

        private void checkBoxDFood_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDFood.Checked == true)
            {
                pastryTotal += 2.00;
                textBoxPastryTotal.Text = String.Format("{0:C2}", pastryTotal);
            }

            if (checkBoxDFood.Checked == false)
            {
                pastryTotal -= 2.00;
                textBoxPastryTotal.Text = String.Format("{0:C2}", pastryTotal);
            }
        }

        private void checkBoxAFood_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAFood.Checked == true)
            {
                pastryTotal += 2.00;
                textBoxPastryTotal.Text = String.Format("{0:C2}", pastryTotal);
            }

            if (checkBoxAFood.Checked == false)
            {
                pastryTotal -= 2.00;
                textBoxPastryTotal.Text = String.Format("{0:C2}", pastryTotal);
            }
        }

        private void checkBoxCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCheese.Checked == true)
            {
                pastryTotal += 2.00;
                textBoxPastryTotal.Text = String.Format("{0:C2}", pastryTotal);
            }

            if (checkBoxCheese.Checked == false)
            {
                pastryTotal -= 2.00;
                textBoxPastryTotal.Text = String.Format("{0:C2}", pastryTotal);
            }
        }

        private void buttonTeaAdd_Click(object sender, EventArgs e)
        {

            listViewOrder.Items.Add(new ListViewItem(new string[] { "Tea", "$2.00" }));
            if (checkBoxTeaCream.Checked == true)
            {
                listViewOrder.Items.Add(new ListViewItem(new string[] { "Cream", "$0.00" }));
            };

            if (checkBoxTeaSugar.Checked == true) {
                listViewOrder.Items.Add(new ListViewItem(new string[] { "Sugar", "$0.00" }));
            };

            if (checkBoxTeaWhippedCream.Checked == true)
            {
                listViewOrder.Items.Add(new ListViewItem(new string[] { "W. Cream", "$0.25" }));
            };

            total += teaTotal;
            labelTotalAmount.Text = String.Format("{0:C2}", total);
            checkBoxTeaSugar.Checked = false;
            checkBoxTeaCream.Checked = false;
            checkBoxTeaWhippedCream.Checked = false;
            
        }

        private void checkBoxTeaWhippedCream_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTeaWhippedCream.Checked == true)
            {
                teaTotal += 0.25;
                textBoxTeaTotal.Text = String.Format("{0:C2}", teaTotal);
            }

            if (checkBoxTeaWhippedCream.Checked == false)
            {
                teaTotal -= 0.25;
                textBoxTeaTotal.Text = String.Format("{0:C2}", teaTotal);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listViewOrder.Items.Clear();
            total = 0.00;
            labelTotalAmount.Text = String.Format("{0:C2}", total);

        }

        private void button2_Click(object sender, EventArgs e)

        {
            listViewOrder.Items.Clear();
            labelTotalAmount.Text = String.Format("{0:C2}", total);
            listViewOrder.Items.Add(new ListViewItem(new string[] { "Thank you.", "Hit clear." }));
        }
    }
}
