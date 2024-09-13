using System.Text.RegularExpressions;

namespace EverydayCarry
{
    public partial class EVDGadgetForm : Form
    {
        public CustomLinkedList<EVDGadget> evdGadgetWeeklyList;
        public string[] weekdays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        public EVDGadgetForm()
        {
            InitializeComponent();
            LoadImages();
            InitializeEVDGadgets();
        }

        //InitializeEVDGadgets() creates a CustomLinkedList of type EVDGadget.
        private void InitializeEVDGadgets()
        {

            evdGadgetWeeklyList = new CustomLinkedList<EVDGadget>();

        }

        //LoadImages() method loads the background image into the appropriate component through its path.
        public void LoadImages()
        {
            string imageBackgroundPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "everyday_gadgets_background.jpg");

            if (File.Exists(imageBackgroundPath))
            {
                picBackground.Image = Image.FromFile(imageBackgroundPath);
                picBackground.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }


        //btnAdd_Click() event handler gets the required details of the everyday gadget, performs error handling, creates an EVDGadget object,
        //and adds it to the list by calling the AddLast() method.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Uses GadgetType enum.
            GadgetType gadgetType = GadgetType.Smartphone;

            //TRY..CATCH handles any exceptions.
            try
            {

                //Microsoft (2024) demonstrates the Interaction.InputBox() method.
                string nameInput = Microsoft.VisualBasic.Interaction.InputBox("Enter Gadget Name:", "Gadget Details");

                string typeInput = Microsoft.VisualBasic.Interaction.InputBox("Select Gadget Type:\n" +
                                                                              "1) Smartphone\n" +
                                                                              "2) Laptop\n" +
                                                                              "3) Smartwatch\n" +
                                                                              "4) Tablet\n" +
                                                                              "5) Bag\n" +
                                                                              "6) Wallet", "Gadget Details");


                while (!CheckTypeInput(int.Parse(typeInput)).isValid)
                {
                    //Microsoft (2024) demonstrates the MessageBox.
                    MessageBox.Show($"{CheckTypeInput(int.Parse(typeInput)).message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    typeInput = Microsoft.VisualBasic.Interaction.InputBox("Select Gadget Type:\n" +
                                                                              "1) Smartphone\n" +
                                                                              "2) Laptop\n" +
                                                                              "3) Smartwatch\n" +
                                                                              "4) Tablet\n" +
                                                                              "5) Bag\n" +
                                                                              "6) Wallet", "Gadget Details");
                }


                //SWITCH clause used to match the type inputted to the enum.
                switch (typeInput)
                {
                    case "1":
                        {
                            gadgetType = GadgetType.Smartphone;
                            break;
                        }
                    case "2":
                        {
                            gadgetType = GadgetType.Laptop;
                            break;
                        }
                    case "3":
                        {
                            gadgetType = GadgetType.Smartwatch;
                            break;
                        }
                    case "4":
                        {
                            gadgetType = GadgetType.Tablet;
                            break;
                        }
                    case "5":
                        {
                            gadgetType = GadgetType.Bag;
                            break;
                        }
                    case "6":
                        {
                            gadgetType = GadgetType.Wallet;
                            break;
                        }
                }//end of SWITCH CLAUSE.


                string dayOfWeekInput = Microsoft.VisualBasic.Interaction.InputBox("Select Days Gadget Is Carried (e.g. 1,2,3):\n" +
                                                                             "1) Monday\n" +
                                                                             "2) Tuesday\n" +
                                                                             "3) Wednesday\n" +
                                                                             "4) Thursday\n" +
                                                                             "5) Friday\n" +
                                                                             "6) Saturday\n" +
                                                                             "7) Sunday", "Gadget Details");

                //Performs error handling for DayOfWeek.
                while (!CheckDaysInput(dayOfWeekInput).isValid)
                {
                    //Microsoft (2024) demonstrates the MessageBox.
                    MessageBox.Show($"{CheckDaysInput(dayOfWeekInput).message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    dayOfWeekInput = Microsoft.VisualBasic.Interaction.InputBox("Select Days Gadget Is Carried (e.g. 1,2,3):\n" +
                                                                                  "1) Monday\n" +
                                                                                  "2) Tuesday\n" +
                                                                                  "3) Wednesday\n" +
                                                                                  "4) Thursday\n" +
                                                                                  "5) Friday\n" +
                                                                                  "6) Saturday\n" +
                                                                                  "7) Sunday", "Gadget Details");

                }


                //Uses the Split() method to divide the week data input into separate elements in the array.
                string[] weekDataInput = dayOfWeekInput.Split(",");

                //Uses the ConvertAll() method to convert the string array to an int array to match EVDGadget class properties.
                evdGadgetWeeklyList.AddLast(new EVDGadget(nameInput, gadgetType, Array.ConvertAll(weekDataInput, int.Parse)));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //btnDisplayAll_Click() event handler displays all the EVD Gadgets added to the list by the days of the week that they
        //are carried.
        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            richOutput.Clear();

            //Loops through Monday-Sunday (to display the week day).
            for (int i = 0; i < weekdays.Length; i++)
            {
                richOutput.AppendText($"{weekdays[i]} : \n");

                //Loops through the EVD Gadget list (to get each gadget).
                foreach (var gadget in evdGadgetWeeklyList)
                {

                    //Loops through each gadget's dayOfWeekCarried array through calling the GetAtIndex() method
                    //(to match the days carried to week day displayed).
                    for (int k = 0; k < gadget.dayOfWeekCarried.Length; k++)
                    {
                        //Checks if the week day it is carried matches the current day of the week
                        //(e.g. if day of week carried is 1 and 2, it would correspond to index 0 and 1 in weekdays).
                        if (gadget.dayOfWeekCarried[k] == (i + 1))
                        {
                            richOutput.AppendText($"{gadget}\n");
                        }
                    }//end of inner for loop.
                }//end of middle for loop.
            }//end of outer for loop.
        }

        //************************************************** EVD GADGET ADDITIONAL METHODS **************************************************

        //CheckTypeInput() method validates the type inputted.
        private (bool isValid, string message) CheckTypeInput(int type)
        {
            if (type > 0 && type <= 6)
            {
                return (true, "");
            }
            else
            {
                return (false, "Please select a valid type (1-6).");
            }
        }

        //CheckDaysInput() method validates the days inputted.
        private (bool isValid, string message) CheckDaysInput(string days)
        {
            //Mozaffar (2024) demonstrates Regular Expressions.
            string pattern = "^([1-7](,[1-7])*)$";

            if (Regex.IsMatch(days, pattern))
            {
                return (true, "");
            }
            else
            {
                return (false, "Please select valid days (1-7) separated by commas.");
            }
        }

        //btnRemove_Click() event handler iterates through the list, matches the value to remove, and calls the Remove() method.
        private void btnRemove_Click(object sender, EventArgs e)
        {

            //Microsoft (2024) demonstrates the Interaction.InputBox() method.
            string nameInput = Microsoft.VisualBasic.Interaction.InputBox("Enter Gadget Name To Remove:", "Remove Gadget");
            bool isFound = false;

            foreach (var gadget in evdGadgetWeeklyList)
            {
                if (gadget.gadgetName.Equals(nameInput))
                {
                    evdGadgetWeeklyList.Remove(gadget);
                    isFound = true;
                    MessageBox.Show("Gadget Removed!");
                }
            }

            if (!isFound)
            {
                MessageBox.Show("Gadget Doesn't Exist!");
            }

        }

        //btnFind_Click() event handler iterates through the list, matches the value to find, calls the Find() method,
        //and shows the result in output.
        private void btnFind_Click(object sender, EventArgs e)
        {
            //Microsoft (2024) demonstrates the Interaction.InputBox() method.
            string nameInput = Microsoft.VisualBasic.Interaction.InputBox("Enter Gadget Name To Find:", "Find Gadget");
            bool isFound = false;

            foreach (var gadget in evdGadgetWeeklyList)
            {
                if (gadget.gadgetName.Equals(nameInput))
                {
                    evdGadgetWeeklyList.Find(gadget);
                    isFound = true;
                    richOutput.Clear();
                    richOutput.AppendText(gadget.ToString());
                }
            }


            if (!isFound)
            {
                MessageBox.Show("Gadget Doesn't Exist!");
            }
        }

        //btnCount_Click() event handler displays the total count of gadgets added to the list.
        private void btnCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Number of gadgets: " + evdGadgetWeeklyList.Count().ToString());
        }

        //btnClear_Click() event handler calls the Clear() method.
        private void btnClear_Click(object sender, EventArgs e)
        {
            evdGadgetWeeklyList.Clear();
        }
    }
}
//REFERENCE LIST:
//Microsoft. 2024. Interaction.InputBox(String, String, String, Int32, Int32) Method (Version 1.0)
//[Source code] https://learn.microsoft.com/en-us/dotnet/api/microsoft.visualbasic.interaction.inputbox?view=net-8.0
//(Accessed 25 July 2024).
//Microsoft. 2024. MessageBox Class (Version 1.0)
//[Source code] https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.messagebox?view=windowsdesktop-8.0
//(Accessed 25 July 2024).
//Mozaffar, A. 2024. Validating User Input Using Regular Expression With C#. C# Corner, 9 August 2024 (Version 2.0)
//[Source code] https://www.c-sharpcorner.com/article/validating-user-input-using-regular-expression-with-c-sharp/
//(Accessed 25 July 2024).

