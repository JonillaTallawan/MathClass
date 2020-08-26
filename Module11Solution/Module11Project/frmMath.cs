using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module11Project
{
    public partial class frmMath : Form
    {
        MathClass Math = new MathClass();
        public frmMath()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbLMessage.Text = "Click a Button";
        }

        private void btnByte_Click(object sender, EventArgs e)
        {
            byte Left = 0;
            byte Right = 0;
            string LNumber = "";
            string RNumber = "";
            string ErrorMessage = "";
            string OutputMessage = "";
            bool TheError = false;
            long Answer = 0;

            LNumber = tbxLeftOperand.Text;
            RNumber = tbxRightOperand.Text;

            if (LNumber == "" || RNumber == "")
            {
                TheError = true;
                ErrorMessage = "You are missing a value in one or both of the texboxes";
            }

            else
            {
                try
                {
                    Left = Convert.ToByte(LNumber);
                }
                catch (FormatException)
                {
                    TheError = true;
                    ErrorMessage = "The Value entered in the Left Operand is not of the format of the button you clicked";
                    ErrorMessage += "\n";
                }
                catch
                {

                    TheError = true;
                    ErrorMessage = "Number you entered in the left Operand is not of the format of the button you clicked";
                    ErrorMessage += "\n";
                }

                try
                {
                    Right = Convert.ToByte(RNumber);
                }


                catch (FormatException)
                {
                    TheError = true;
                    ErrorMessage += "The Value entered in the Right Operand is not of the format of the button you clicked";
                    ErrorMessage += "\n";
                }
                catch
                {
                    TheError = true;
                    ErrorMessage += "Number you entered in the Right Operand is not of the format of the button you clicked";
                    ErrorMessage += "\n";
                }

            }

            if (TheError == true)
            {
                OutputMessage += ErrorMessage;
            }

            else
            {
                if (rbtnAdd.Checked == true)
                {

                    Answer = Math.ByteOperationADD(Left, Right);

                    OutputMessage = Left + " + " + Right + " = " + Answer;
                }
                else if (rbtnSubtract.Checked == true)
                {

                    Answer = Math.ByteOperationMINUS(Left, Right);

                    OutputMessage = Left + " - " + Right + " = " + Answer;
                }
                else if (rbtnMultiply.Checked == true)
                {
                    Answer = Math.ByteOperationMULTIPLY(Left, Right);

                    OutputMessage = Left + " * " + Right + " = " + Answer;
                }
                else if (rbtnDivide.Checked == true)
                {
                    if (Right <= 0)
                    {
                        OutputMessage += "Use a number that is higher than zero in your right operand if you are using the Division";
                    }
                    else
                    {
                        Answer = Math.ByteOperationDIVISION(Left, Right);
                        OutputMessage = Left + " / " + Right + " = " + Answer;
                    }
                }
                else if (rbtnModulus.Checked == true)
                {
                    if (Right <= 0)
                    {
                        OutputMessage += "Use a number that is higher than zero in your right operand if you are using the modulus";
                    }
                    else
                    {
                        Answer = Math.ByteOperationMODULUS(Left, Right);
                        OutputMessage = Left + " % " + Right + " = " + Answer;
                    }
                }
                else
                {
                    OutputMessage += "You have not pressed any radio button";
                }

            }
            lbLMessage.Text = OutputMessage;

        }

        private void btnShort_Click(object sender, EventArgs e)
        {
            short Left = 0;
            short Right = 0;
            string LNumber = "";
            string RNumber = "";
            string ErrorMessage = "";
            string OutputMessage = "";
            bool TheError = false;
            long Answer = 0;

            LNumber = tbxLeftOperand.Text;
            RNumber = tbxRightOperand.Text;

            if (LNumber == "" || RNumber == "")
            {
                TheError = true;
                ErrorMessage = "You are missing a value in one or both of the texboxes";
            }

            else
            {
                try
                {
                    Left = Convert.ToInt16(LNumber);
                }
                catch (FormatException)
                {
                    TheError = true;
                    ErrorMessage = "The Value entered in the Left Operand is not of the format of the button you clicked";
                    ErrorMessage += "\n";
                }
                catch
                {

                    TheError = true;
                    ErrorMessage = "Number you entered in the left Operand is not of the format of the button you clicked";
                    ErrorMessage += "\n";
                }

                try
                {
                    Right = Convert.ToInt16(RNumber);
                }


                catch (FormatException)
                {
                    TheError = true;
                    ErrorMessage += "The Value entered in the Right Operand is not of the format of the button you clicked";
                    ErrorMessage += "\n";
                }
                catch
                {
                    TheError = true;
                    ErrorMessage += "Number you entered in the Right Operand is not of the format of the button you clicked";
                    ErrorMessage += "\n";
                }

            }

            if (TheError == true)
            {
                OutputMessage += ErrorMessage;
            }

            else
            {
                if (rbtnAdd.Checked == true)
                {

                    Answer = Math.ShortOperationADD(Left, Right);

                    OutputMessage = Left + " + " + Right + " = " + Answer;
                }
                else if (rbtnSubtract.Checked == true)
                {

                    Answer = Math.ShortOperationMINUS(Left, Right);

                    OutputMessage = Left + " - " + Right + " = " + Answer;
                }
                else if (rbtnMultiply.Checked == true)
                {
                    Answer = Math.ShortOperationMULTIPLY(Left, Right);

                    OutputMessage = Left + " * " + Right + " = " + Answer;
                }
                else if (rbtnDivide.Checked == true)
                {
                    if (Right <= 0)
                    {
                        OutputMessage += "Use a number that is higher than zero in your right operand if you are using the Division";
                    }
                    else
                    {
                        Answer = Math.ShortOperationDIVISION(Left, Right);
                        OutputMessage = Left + " / " + Right + " = " + Answer;
                    }
                }
                else if (rbtnModulus.Checked == true)
                {
                    if (Right <= 0)
                    {
                        OutputMessage += "Use a number that is higher than zero in your right operand if you are using the modulus";
                    }
                    else
                    {
                        Answer = Math.ShortOperationMODULUS(Left, Right);
                        OutputMessage = Left + " % " + Right + " = " + Answer;
                    }
                }
                else
                {
                    OutputMessage += "You have not pressed any radio button";
                }
                lbLMessage.Text = OutputMessage;

            }
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            int Left = 0;
            int Right = 0;
            string LNumber = "";
            string RNumber = "";
            string ErrorMessage = "";
            string OutputMessage = "";
            bool TheError = false;
            long Answer = 0;

            LNumber = tbxLeftOperand.Text;
            RNumber = tbxRightOperand.Text;

            if (LNumber == "" || RNumber == "")
            {
                TheError = true;
                ErrorMessage = "You are missing a value in one or both of the texboxes";
            }

            else
            {
                try
                {
                    Left = Convert.ToInt32(LNumber);
                }
                catch (FormatException)
                {
                    TheError = true;
                    ErrorMessage = "The Value entered in the Left Operand is not of the format of the button you clicked";
                    ErrorMessage += "\n";
                }
                catch
                {

                    TheError = true;
                    ErrorMessage = "Number you entered in the left Operand is not of the format of the button you clicked";
                    ErrorMessage += "\n";
                }

                try
                {
                    Right = Convert.ToInt32(RNumber);
                }


                catch (FormatException)
                {
                    TheError = true;
                    ErrorMessage += "The Value entered in the Right Operand is not of the format of the button you clicked";
                    ErrorMessage += "\n";
                }
                catch
                {
                    TheError = true;
                    ErrorMessage += "Number you entered in the Right Operand is not of the format of the button you clicked";
                    ErrorMessage += "\n";
                }

            }

            if (TheError)
            {
                OutputMessage += ErrorMessage;
            }

            else
            {
                if (rbtnAdd.Checked == true)
                {

                    Answer = Math.IntOperationADD(Left, Right);

                    OutputMessage = Left + " + " + Right + " = " + Answer;
                }
                else if (rbtnSubtract.Checked == true)
                {

                    Answer = Math.IntOperationMINUS(Left, Right);

                    OutputMessage = Left + " - " + Right + " = " + Answer;
                }
                else if (rbtnMultiply.Checked == true)
                {
                    Answer = Math.IntOperationMULTIPLY(Left, Right);

                    OutputMessage = Left + " * " + Right + " = " + Answer;
                }
                else if (rbtnDivide.Checked == true)
                {
                    if (Right <= 0)
                    {
                        OutputMessage += "Use a number that is higher than zero in your right operand if you are using the Division";
                    }
                    else
                    {
                        Answer = Math.IntOperationDIVISION(Left, Right);
                        OutputMessage = Left + " / " + Right + " = " + Answer;
                    }
                }
                else if (rbtnModulus.Checked == true)
                {
                    if (Right <= 0)
                    {
                        OutputMessage += "Use a number that is higher than zero in your right operand if you are using the modulus";
                    }
                    else
                    {
                        Answer = Math.IntOperationMODULUS(Left, Right);
                        OutputMessage = Left + " % " + Right + " = " + Answer;
                    }
                }
                else
                {
                    OutputMessage += "You have not pressed any radio button";
                }
                lbLMessage.Text = OutputMessage;

            }

        }

        private void btnLong_Click(object sender, EventArgs e)
        {
            long Left = 0;
            long Right = 0;
            string LNumber = "";
            string RNumber = "";
            string ErrorMessage = "";
            string OutputMessage = "";
            bool TheError = false;
            long Answer = 0;

            LNumber = tbxLeftOperand.Text;
            RNumber = tbxRightOperand.Text;

            if (LNumber == "" || RNumber == "")
            {
                TheError = true;
                ErrorMessage = "You are missing a value in one or both of the texboxes";
            }

            else
            {
                try
                {
                    Left = Convert.ToInt64(LNumber);
                }
                catch (FormatException)
                {
                    TheError = true;
                    ErrorMessage = "The Value entered in the Left Operand is not of the format of the button you clicked";
                    ErrorMessage += "\n";
                }
                catch
                {

                    TheError = true;
                    ErrorMessage = "Number you entered in the left Operand is not of the format of the button you clicked";
                    ErrorMessage += "\n";
                }

                try
                {
                    Right = Convert.ToInt64(RNumber);
                }


                catch (FormatException)
                {
                    TheError = true;
                    ErrorMessage += "The Value entered in the Right Operand is not of the format of the button you clicked";
                    ErrorMessage += "\n";
                }
                catch
                {
                    TheError = true;
                    ErrorMessage += "Number you entered in the Right Operand is not of the format of the button you clicked";
                    ErrorMessage += "\n";
                }

            }

            if (TheError)
            {
                OutputMessage += ErrorMessage;
            }

            else
            {
                if (rbtnAdd.Checked == true)
                {

                    Answer = Math.LongOperationADD(Left, Right);

                    OutputMessage = Left + " + " + Right + " = " + Answer;
                }
                else if (rbtnSubtract.Checked == true)
                {

                    Answer = Math.LongOperationMINUS(Left, Right);

                    OutputMessage = Left + " - " + Right + " = " + Answer;
                }
                else if (rbtnMultiply.Checked == true)
                {
                    Answer = Math.LongOperationMULTIPLY(Left, Right);

                    OutputMessage = Left + " * " + Right + " = " + Answer;
                }
                else if (rbtnDivide.Checked == true)
                {
                    if (Right <= 0)
                    {
                        OutputMessage += "Use a number that is higher than zero in your right operand if you are using the Division";
                    }
                    else
                    {
                        Answer = Math.LongOperationDIVISION(Left, Right);
                        OutputMessage = Left + " / " + Right + " = " + Answer;
                    }
                }
                else if (rbtnModulus.Checked == true)
                {
                    if (Right <= 0)
                    {
                        OutputMessage += "Use a number that is higher than zero in your right operand if you are using the modulus";
                    }
                    else
                    {
                        Answer = Math.LongOperationMODULUS(Left, Right);
                        OutputMessage = Left + " % " + Right + " = " + Answer;
                    }
                }
                else
                {
                    OutputMessage += "You have not pressed any radio button";
                }
                lbLMessage.Text = OutputMessage;

            }

        }

        private void btnFloat_Click(object sender, EventArgs e)
        {
            Single Left = 0;
            Single Right = 0;
            string LNumber = "";
            string RNumber = "";
            string ErrorMessage = "";
            string OutputMessage = "";
            bool TheError = false;
            decimal Answer = 0;

            LNumber = tbxLeftOperand.Text;
            RNumber = tbxRightOperand.Text;

            if (LNumber == "" || RNumber == "")
            {
                TheError = true;
                ErrorMessage = "You are missing a value in one or both of the texboxes";
            }

            else
            {
                try
                {
                    Left = Convert.ToSingle(LNumber);
                }
                catch (FormatException)
                {
                    TheError = true;
                    ErrorMessage = "The Value entered in the Left Operand is not of the format of the button you clicked";
                    ErrorMessage += "\n";
                }
                catch
                {

                    TheError = true;
                    ErrorMessage = "Number you entered in the left Operand is not of the format of the button you clicked";
                    ErrorMessage += "\n";
                }

                try
                {
                    Right = Convert.ToSingle(RNumber);
                }


                catch (FormatException)
                {
                    TheError = true;
                    ErrorMessage += "The Value entered in the Right Operand is not of the format of the button you clicked";
                    ErrorMessage += "\n";
                }
                catch
                {
                    TheError = true;
                    ErrorMessage += "Number you entered in the Right Operand is not of the format of the button you clicked";
                    ErrorMessage += "\n";
                }

            }

            if (TheError)
            {
                OutputMessage += ErrorMessage;
            }

            else
            {
                if (rbtnAdd.Checked == true)
                {

                    Answer = Math.FloatOperationADD(Left, Right);

                    OutputMessage = Left + " + " + Right + " = " + Answer;
                }
                else if (rbtnSubtract.Checked == true)
                {

                    Answer = Math.FloatOperationMINUS(Left, Right);

                    OutputMessage = Left + " - " + Right + " = " + Answer;
                }
                else if (rbtnMultiply.Checked == true)
                {
                    Answer = Math.FloatOperationMULTIPLY(Left, Right);

                    OutputMessage = Left + " * " + Right + " = " + Answer;
                }
                else if (rbtnDivide.Checked == true)
                {
                    if (Right <= 0)
                    {
                        OutputMessage += "Use a number that is higher than zero in your right operand if you are using the Division";
                    }
                    else
                    {
                        Answer = Math.FloatOperationDIVISION(Left, Right);
                        OutputMessage = Left + " / " + Right + " = " + Answer;
                    }
                }
                else if (rbtnModulus.Checked == true)
                {
                    if (Right <= 0)
                    {
                        OutputMessage += "Use a number that is higher than zero in your right operand if you are using the modulus";
                    }
                    else
                    {
                        Answer = Math.FloatOperationMODULUS(Left, Right);
                        OutputMessage = Left + " % " + Right + " = " + Answer;
                    }
                }
                else
                {
                    OutputMessage += "You have not pressed any radio button";
                }
                lbLMessage.Text = OutputMessage;

            }

        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            double Left = 0;
            double Right = 0;
            string LNumber = "";
            string RNumber = "";
            string ErrorMessage = "";
            string OutputMessage = "";
            bool TheError = false;
            decimal Answer = 0;

            LNumber = tbxLeftOperand.Text;
            RNumber = tbxRightOperand.Text;

            if (LNumber == "" || RNumber == "")
            {
                TheError = true;
                ErrorMessage = "You are missing a value in one or both of the texboxes";
            }

            else
            {
                try
                {
                    Left = Convert.ToDouble(LNumber);
                }
                catch (FormatException)
                {
                    TheError = true;
                    ErrorMessage = "The Value entered in the Left Operand is not of the format of the button you clicked";
                    ErrorMessage += "\n";
                }
                catch
                {

                    TheError = true;
                    ErrorMessage = "Number you entered in the left Operand is not of the format of the button you clicked";
                    ErrorMessage += "\n";
                }

                try
                {
                    Right = Convert.ToDouble(RNumber);
                }


                catch (FormatException)
                {
                    TheError = true;
                    ErrorMessage += "The Value entered in the Right Operand is not of the format of the button you clicked";
                    ErrorMessage += "\n";
                }
                catch
                {
                    TheError = true;
                    ErrorMessage += "Number you entered in the Right Operand is not of the format of the button you clicked";
                    ErrorMessage += "\n";
                }

            }

            if (TheError)
            {
                OutputMessage += ErrorMessage;
            }

            else
            {
                if (rbtnAdd.Checked == true)
                {

                    Answer = Math.DoubleOperationADD(Left, Right);

                    OutputMessage = Left + " + " + Right + " = " + Answer;
                }
                else if (rbtnSubtract.Checked == true)
                {

                    Answer = Math.DoubleOperationMINUS(Left, Right);

                    OutputMessage = Left + " - " + Right + " = " + Answer;
                }
                else if (rbtnMultiply.Checked == true)
                {
                    Answer = Math.DoubleOperationMULTIPLY(Left, Right);

                    OutputMessage = Left + " * " + Right + " = " + Answer;
                }
                else if (rbtnDivide.Checked == true)
                {
                    if (Right <= 0)
                    {
                        OutputMessage += "Use a number that is higher than zero in your right operand if you are using the Division";
                    }
                    else
                    {
                        Answer = Math.DoubleOperationDIVISION(Left, Right);
                        OutputMessage = Left + " / " + Right + " = " + Answer;
                    }
                }
                else if (rbtnModulus.Checked == true)
                {
                    if (Right <= 0)
                    {
                        OutputMessage += "Use a number that is higher than zero in your right operand if you are using the modulus";
                    }
                    else
                    {
                        Answer = Math.DoubleOperationMODULUS(Left, Right);
                        OutputMessage = Left + " % " + Right + " = " + Answer;
                    }
                }
                else
                {
                    OutputMessage += "You have not pressed any radio button";
                }
                lbLMessage.Text = OutputMessage;

            }
            lbLMessage.Text = OutputMessage;

        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            decimal Left = 0;
            decimal Right = 0;
            string LNumber = "";
            string RNumber = "";
            string ErrorMessage = "";
            string OutputMessage = "";
            bool TheError = false;
            decimal Answer = 0;

            LNumber = tbxLeftOperand.Text;
            RNumber = tbxRightOperand.Text;

            if (LNumber == "" || RNumber == "")
            {
                TheError = true;
                ErrorMessage = "You are missing a value in one or both of the texboxes";
            }

            else
            {
                try
                {
                    Left = Convert.ToDecimal(LNumber);
                }
                catch (FormatException)
                {
                    TheError = true;
                    ErrorMessage = "The Value entered in the Left Operand is not of the format of the button you clicked";
                    ErrorMessage += "\n";
                }
                catch
                {

                    TheError = true;
                    ErrorMessage = "Number you entered in the left Operand is not of the format of the button you clicked";
                    ErrorMessage += "\n";
                }

                try
                {
                    Right = Convert.ToDecimal(RNumber);
                }


                catch (FormatException)
                {
                    TheError = true;
                    ErrorMessage += "The Value entered in the Right Operand is not of the format of the button you clicked";
                    ErrorMessage += "\n";
                }
                catch
                {
                    TheError = true;
                    ErrorMessage += "Number you entered in the Right Operand is not of the format of the button you clicked";
                    ErrorMessage += "\n";
                }

            }

            if (TheError)
            {
                OutputMessage += ErrorMessage;
            }

            else
            {
                if (rbtnAdd.Checked == true)
                {

                    Answer = Math.DecimalOperationADD(Left, Right);

                    OutputMessage = Left + " + " + Right + " = " + Answer;
                }
                else if (rbtnSubtract.Checked == true)
                {

                    Answer = Math.DecimalOperationMINUS(Left, Right);

                    OutputMessage = Left + " - " + Right + " = " + Answer;
                }
                else if (rbtnMultiply.Checked == true)
                {
                    Answer = Math.DecimalOperationMULTIPLY(Left, Right);

                    OutputMessage = Left + " * " + Right + " = " + Answer;
                }
                else if (rbtnDivide.Checked == true)
                {
                    if (Right <= 0)
                    {
                        OutputMessage += "Use a number that is higher than zero in your right operand if you are using the Division";
                    }
                    else
                    {
                        Answer = Math.DecimalOperationDIVISION(Left, Right);
                        OutputMessage = Left + " / " + Right + " = " + Answer;
                    }
                }
                else if (rbtnModulus.Checked == true)
                {
                    if (Right <= 0)
                    {
                        OutputMessage += "Use a number that is higher than zero in your right operand if you are using the modulus";
                    }
                    else
                    {
                        Answer = Math.DecimalOperationMODULUS(Left, Right);
                        OutputMessage = Left + " % " + Right + " = " + Answer;
                    }
                }
                else
                {
                    OutputMessage += "You have not pressed any radio button";
                }
                lbLMessage.Text = OutputMessage;

            }
        }
    }
}
