using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Engine;//to have access to the player class since it is in another project(Engine)

namespace FirstGame
{
    public partial class SuperAdventure : Form
    {
        private Player _player;//a place to store the player object and have it as a class scope. an alternative to creating it in the constructor which would not have the same scope. ok...
        public SuperAdventure()
        {
            InitializeComponent();

            var location = new Location(1, "Home", "This is your house");

            /*new Player();= creates an object and it is being assigned to the variable _player we created at class scope lvl
             now that Player object has been created the below steps set the properties and assign its values
             --again...values being assigned to the properties of the _player object*/
            _player = new Player();
            _player.CurrentHitPoints = 10;
            _player.MaximumHitPoints = 10; 
            _player.Gold = 20;
            _player.ExperiencePoints = 0;
            _player.Level = 1;
            
            //below step is getting values from the _player object and assigning them to text of the label on the screen

            lblHitPoints.Text = _player.CurrentHitPoints.ToString();//because _player properties are of type int, the ToString method is a simple way of converting such data type to type string. 
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
