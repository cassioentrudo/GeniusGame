using System.Drawing;
using System.Windows.Forms;

namespace GeniusGame
{
    public class Botao
    {
        public Botao(Button buttonForm, Image imageNormal, Image imagePress)
        {
            this.imageNormal = imageNormal;
            this.imagePress = imagePress;
            this.buttonForm = buttonForm;
        }

        private Image imageNormal = null;

        private Image imagePress = null;

        private Button buttonForm = null;


        public Image ImageNormal
        {
            get { return this.imageNormal; }
        }

        public Image ImagePress
        {
            get
            {
                return this.imagePress;
            }
        }

        public Button ButtonForm
        {
            get
            {
                return this.buttonForm;
            }
        }
    }
}
