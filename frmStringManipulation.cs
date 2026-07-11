using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_29___String_Manipulation_Form__
{
    public partial class frmStringManipulation : Form
    {
        public frmStringManipulation()
        {
            InitializeComponent();
        }

        private void ClearTextbox(TextBox txtbox)
        {
            txtbox.Clear();
        }

        private void ClearInputSection()
        {
            ClearTextbox(txtInput);
            ClearTextbox(txtCharacters);
            ClearTextbox(txtWords);
            ClearTextbox(txtLastWord);
            ClearTextbox(txtFirstWord);
        }

        private void ClearOutputSection()
        {
            ClearTextbox(txtOutput);
        }

        private void ClearExtractSection()
        {
            ClearTextbox(txtStartIndex);
            ClearTextbox(txtLength);
        }

        private void ClearTransformSection()
        {
            ClearTextbox(txtFind);
            ClearTextbox(txtReplaceWith);
        }

        private void ClearAllTextboxes()
        {
            ClearInputSection();
            ClearOutputSection();
            ClearExtractSection();
            ClearTransformSection();
        }

        private bool IsOutputTextboxEmpty()
        {
            return string.IsNullOrEmpty(txtOutput.Text);
        }

        private bool IsInputTextboxEmpty()
        {
            return string.IsNullOrEmpty(txtInput.Text);
        }

        private bool IsExtractSectionEmpty()
        {
            return (string.IsNullOrWhiteSpace(txtStartIndex.Text) ||
                string.IsNullOrWhiteSpace(txtLength.Text));
        }

        private bool IsValidStartIndex()
        {
            return (Convert.ToSByte(txtStartIndex.Text) >= 0 &&
                Convert.ToSByte(txtStartIndex.Text) < txtInput.TextLength);
        }

        private bool IsValidExtractInfo()
        {
            return (!IsExtractSectionEmpty() && !IsInputTextboxEmpty() && IsValidStartIndex() && IsValidSubstringLength());
        }

        private bool IsValidSubstringLength()
        {
            return (Convert.ToByte(txtLength.Text) <= (txtInput.TextLength - Convert.ToByte(txtStartIndex.Text)));
        }

        private bool IsTextExistsInInputValue()
        {
            return (txtInput.Text.Contains(txtFind.Text));
        }

        private bool IsTransformSectionEmpty()
        {
            return (string.IsNullOrWhiteSpace(txtFind.Text) || string.IsNullOrWhiteSpace(txtReplaceWith.Text));
        }

        private bool IsValidReplaceInfo()
        {
            return (IsTextExistsInInputValue() && !IsTransformSectionEmpty() && !IsInputTextboxEmpty());
        }

        private void ReplaceAll()
        {
            txtOutput.Text = txtInput.Text.Replace(txtFind.Text, txtReplaceWith.Text);
        }

        private void ReplaceFirst()
        {
            byte index = Convert.ToByte(txtInput.Text.IndexOf(txtFind.Text));

            txtOutput.Text = txtInput.Text.Remove(index, txtFind.TextLength);

            txtOutput.Text = txtOutput.Text.Insert(index, txtReplaceWith.Text);
        }

        private void GetSubstring()
        {
            txtOutput.Text = txtInput.Text.Substring(Convert.ToByte(txtStartIndex.Text), Convert.ToByte(txtLength.Text));
        }

        private void CopyOutput()
        {
            if (!IsOutputTextboxEmpty())
            {
                txtOutput.SelectAll();
                txtOutput.Copy();
            }
        }

        private void FillInputInfo()
        {
            string[] SplitedString = txtInput.Text.Split(' ');

            txtFirstWord.Text = SplitedString[0];

            txtCharacters.Text = txtInput.TextLength.ToString();

            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                txtWords.Text = "0";
                txtLastWord.Clear();
            }
            else if (txtInput.Text[txtInput.TextLength - 1] == ' ')
            {
                txtWords.Text = (SplitedString.Length-1).ToString();
                txtLastWord.Text = SplitedString[SplitedString.Length - 2];
            }
            else
            {
                txtWords.Text = SplitedString.Length.ToString();
                txtLastWord.Text = SplitedString[SplitedString.Length - 1];
            }
        }

        private void FillOutput()
        {
            txtOutput.Text = txtInput.Text;
        }

        private void ToUpper()
        {
            txtOutput.Text = txtInput.Text.ToUpper();
        }

        private void ToLower()
        {
            txtOutput.Text = txtInput.Text.ToLower();
        }

        private void AsInput()
        {
            txtOutput.Text = txtInput.Text;
        }

        private void Trim()
        {
            txtOutput.Text = txtInput.Text.Trim();
        }

        private void TrimStart()
        {
            txtOutput.Text = txtInput.Text.TrimStart();
        }

        private void TrimEnd()
        {
            txtOutput.Text = txtInput.Text.TrimEnd();
        }

        private void RemoveSpaces()
        {
            txtOutput.Text = txtInput.Text.Replace(" ", "");
        }

        private void btnClearInput_Click(object sender, EventArgs e)
        {
            ClearInputSection();
        }

        private void btnGetSubstring_Click(object sender, EventArgs e)
        {
            if (IsValidExtractInfo())
            {
                GetSubstring();
            }
        }

        private void bttnReplace_Click(object sender, EventArgs e)
        {
            if (IsValidReplaceInfo())
            {
                switch (((Button)sender).Tag)
                {
                    case "ReplaceAll":

                        ReplaceAll();
                        break;

                    case "ReplaceFirst":

                        ReplaceFirst();
                        break;
                }
            }
        }

        private void btnOutputOperations_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Tag)
            {
                case "CopyOutput":

                    CopyOutput();
                    break;

                case "ClearOutput":

                    ClearOutputSection();
                    break;

                case "ClearAll":

                    ClearAllTextboxes();
                    break;
            }
        }

        private void btnCaseOperations_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Tag)
            {
                case "ToUpper":

                    ToUpper();
                    break;

                case "ToLower":

                    ToLower();
                    break;

                case "AsInput":

                    AsInput();
                    break;
            }
        }

        private void btnTransformations_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Tag)
            {
                case "Trim":

                    Trim();
                    break;

                case "TrimStart":

                    TrimStart();
                    break;

                case "TrimEnd":

                    TrimEnd();
                    break;

                case "RemoveSpaces":

                    RemoveSpaces();
                    break;
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            FillInputInfo();
            FillOutput();
        }
    }
}
