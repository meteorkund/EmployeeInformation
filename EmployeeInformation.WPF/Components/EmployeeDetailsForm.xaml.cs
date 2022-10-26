using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EmployeeInformation.WPF.Components
{
    /// <summary>
    /// Interaction logic for EmployeeDetailsForm.xaml
    /// </summary>
    public partial class EmployeeDetailsForm : UserControl
    {
        public EmployeeDetailsForm()
        {
            InitializeComponent();            
        }

        private void cboTest_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            ComboBox cbo = sender as ComboBox;

            if (cbo != null)
            {
                TextBox txt = cbo.Template.FindName("PART_EditableTextBox", cbo) as TextBox;

                if (txt != null)
                {
                    txt.CharacterCasing = CharacterCasing.Upper;
                }
            }
        }

        private void NumericOnly(object sender, TextCompositionEventArgs e)
        {
            e.Handled = IsTextNumeric(e.Text);
        }

        private static bool IsTextNumeric(string str)
        {
            System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex("[^0-9]");
            return reg.IsMatch(str);
        }
    }
}
