using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0830_OOP {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            CAnimal obj = new CAnimal();
            obj.MakeNoise();
        }

        class CAnimal {
            private int _Weight;  //底線可以表示自用

            public int Weight {
                set {
                    this._Weight = value;
                }
                get {
                    return this._Weight;
                }
            }

            public void SetWeight(int WeightValue) {
                this._Weight = WeightValue;
            }
            public int GetWeight() {
                return this._Weight;
            }
            public void MakeNoise() {
                MessageBox.Show("Animail:...");
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            CAnimal obj2 = new CAnimal();
            obj2.SetWeight(10);
            button2.Text = obj2.GetWeight().ToString();            
        }

        private void button3_Click(object sender, EventArgs e) {
            CAnimal obj3 = new CAnimal();
            obj3.Weight = 13;
            button3.Text = obj3.Weight.ToString();
        }
    }
}
