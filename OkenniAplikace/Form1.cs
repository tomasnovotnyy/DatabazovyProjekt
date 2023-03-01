using Microsoft.VisualBasic;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace OkenniAplikace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Tlačítko, kterým vkládám data do tabulky Výrobce
        private void button1_Click(object sender, EventArgs e)
        {
            string nazev = textBox1.Text;
            string email = textBox2.Text;

            try
            {
                //System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"]) používám pro zjednodušení připojení do databáze pomocí App.config, kde mohu lehce změnit všechny potřebné informace
                using (SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"]))
                {
                    //Kontrola, zda jsem se úspěšně připojil k databázi
                    connection.Open();
                    Console.WriteLine("Pripojeno");
                    
                    //Příkaz INSERT INTO k přídání dat do tabulky
                    //Zde používám @par pro 'odkazování' na jednotlivé sloupce v tabulce, jako například název, email atd.
                    string query = "INSERT INTO Vyrobce(nazev,email) values(@par1,@par2)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@par1", nazev);
                        command.Parameters.AddWithValue("@par2", email);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            //Po zmáčknutí tlačítka se text nastaví na prázdný
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        // Tlačítko, kterým vkládám data do tabulky Výrobek
        private void button4_Click(object sender, EventArgs e)
        {
            string vyrobce_id = textBox8.Text;
            string typ = textBox7.Text;
            string nazev = textBox6.Text;
            string cena_ks = textBox5.Text;

            try
            {
                //System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"]) používám pro zjednodušení připojení do databáze pomocí App.config, kde mohu lehce změnit všechny potřebné informace
                using (SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"]))
                {
                    //Kontrola, zda jsem se úspěšně připojil k databázi
                    connection.Open();
                    Console.WriteLine("Pripojeno");

                    //Příkaz INSERT INTO k přídání dat do tabulky
                    //Zde používám @par pro 'odkazování' na jednotlivé sloupce v tabulce, jako například název, email atd.
                    string query = "INSERT INTO Vyrobek(vyrobce_id,typ,nazev,cena_ks) values(@par1,@par2,@par3,@par4)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@par1", vyrobce_id);
                        command.Parameters.AddWithValue("@par2", typ);
                        command.Parameters.AddWithValue("@par3", nazev);
                        command.Parameters.AddWithValue("@par4", cena_ks);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            //Po zmáčknutí tlačítka se text nastaví na prázdný
            textBox8.Text = "";
            textBox7.Text = "";
            textBox6.Text = "";
            textBox5.Text = "";
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        // Tlačítko, kterým vkládám data do tabulky Položka
        private void button6_Click(object sender, EventArgs e)
        {
            string obj_id = textBox12.Text;
            string vyrobek_id = textBox11.Text;
            string pocet_ks = textBox10.Text;
            string cena_polozky = textBox9.Text;

            try
            {
                //System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"]) používám pro zjednodušení připojení do databáze pomocí App.config, kde mohu lehce změnit všechny potřebné informace
                using (SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"]))
                {
                    //Kontrola, zda jsem se úspěšně připojil k databázi
                    connection.Open();
                    Console.WriteLine("Pripojeno");

                    //Příkaz INSERT INTO k přídání dat do tabulky
                    //Zde používám @par pro 'odkazování' na jednotlivé sloupce v tabulce, jako například název, email atd.
                    string query = "INSERT INTO Polozka(obj_id,vyrobek_id,pocet_ks,cena_polozky) values(@par1,@par2,@par3,@par4)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@par1", obj_id);
                        command.Parameters.AddWithValue("@par2", vyrobek_id);
                        command.Parameters.AddWithValue("@par3", pocet_ks);
                        command.Parameters.AddWithValue("@par4", cena_polozky);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            //Po zmáčknutí tlačítka se text nastaví na prázdný
            textBox12.Text = "";
            textBox11.Text = "";
            textBox10.Text = "";
            textBox9.Text = "";
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        // Tlačítko, kterým vkládám data do tabulky Objednávka
        private void button8_Click(object sender, EventArgs e)
        {
            string zak_id = textBox16.Text;
            string cis_obj = textBox15.Text;
            string datum = textBox14.Text;
            string cena_objednavky = textBox13.Text;

            try
            {
                //System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"]) používám pro zjednodušení připojení do databáze pomocí App.config, kde mohu lehce změnit všechny potřebné informace
                using (SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"]))
                {
                    //Kontrola, zda jsem se úspěšně připojil k databázi
                    connection.Open();
                    Console.WriteLine("Pripojeno");

                    //Příkaz INSERT INTO k přídání dat do tabulky
                    //Zde používám @par pro 'odkazování' na jednotlivé sloupce v tabulce, jako například název, email atd.
                    string query = "INSERT INTO Objednavka(zak_id,cis_obj,datum,cena_objednavky) values(@par1,@par2,@par3,@par4)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@par1", zak_id);
                        command.Parameters.AddWithValue("@par2", cis_obj);
                        command.Parameters.AddWithValue("@par3", datum);
                        command.Parameters.AddWithValue("@par4", cena_objednavky);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            //Po zmáčknutí tlačítka se text nastaví na prázdný
            textBox16.Text = "";
            textBox15.Text = "";
            textBox14.Text = "";
            textBox13.Text = "";
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        // Tlačítko, kterým vkládám data do tabulky Zákazník
        private void button10_Click(object sender, EventArgs e)
        {
            string prijmeni = textBox20.Text;
            string email = textBox19.Text;

            try
            {
                //System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"]) používám pro zjednodušení připojení do databáze pomocí App.config, kde mohu lehce změnit všechny potřebné informace
                using (SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"]))
                {
                    //Kontrola, zda jsem se úspěšně připojil k databázi
                    connection.Open();
                    Console.WriteLine("Pripojeno");

                    //Příkaz INSERT INTO k přídání dat do tabulky
                    //Zde používám @par pro 'odkazování' na jednotlivé sloupce v tabulce, jako například název, email atd.
                    string query = "INSERT INTO Zakaznik(prijmeni,email) values(@par1,@par2)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@par1", prijmeni);
                        command.Parameters.AddWithValue("@par2", email);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            //Po zmáčknutí tlačítka se text nastaví na prázdný
            textBox20.Text = "";
            textBox19.Text = "";
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        // Tlačítko, kterým mažu data z tabulky Výrobce
        private void button20_Click(object sender, EventArgs e)
        {
            string nazev = textBox1.Text;
            string email = textBox2.Text;

            try
            {
                //System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"]) používám pro zjednodušení připojení do databáze pomocí App.config, kde mohu lehce změnit všechny potřebné informace
                using (SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"]))
                {
                    //Kontrola, zda jsem se úspěšně připojil k databázi
                    connection.Open();
                    Console.WriteLine("Pripojeno");

                    //Příkaz DELETE FROM pro smazání dat z tabulky
                    //Zde používám @par pro 'odkazování' na jednotlivé sloupce v tabulce, jako například název, email atd.
                    string query = "DELETE FROM Vyrobce WHERE nazev=@par1 OR email=@par2";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@par1", nazev);
                        command.Parameters.AddWithValue("@par2", email);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            //Po zmáčknutí tlačítka se text nastaví na prázdný
            textBox1.Text = "";
            textBox2.Text = "";
        }

        // Tlačítko, kterým mažu data z tabulky Výrobek
        private void button19_Click(object sender, EventArgs e)
        {
            string vyrobce_id = textBox8.Text;
            string typ = textBox7.Text;
            string nazev = textBox6.Text;
            string cena_ks = textBox5.Text;

            try
            {
                //System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"]) používám pro zjednodušení připojení do databáze pomocí App.config, kde mohu lehce změnit všechny potřebné informace
                using (SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"]))
                {
                    //Kontrola, zda jsem se úspěšně připojil k databázi
                    connection.Open();
                    Console.WriteLine("Pripojeno");

                    //Příkaz DELETE FROM pro smazání dat z tabulky
                    //Zde používám @par pro 'odkazování' na jednotlivé sloupce v tabulce, jako například název, email atd.
                    string query = "DELETE FROM Vyrobek WHERE vyrobce_id=@par1 OR typ=@par2 OR nazev=@par3 OR cena_ks=@par4";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@par1", vyrobce_id);
                        command.Parameters.AddWithValue("@par2", typ);
                        command.Parameters.AddWithValue("@par3", nazev);
                        command.Parameters.AddWithValue("@par4", cena_ks);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            //Po zmáčknutí tlačítka se text nastaví na prázdný
            textBox8.Text = "";
            textBox7.Text = "";
            textBox6.Text = "";
            textBox5.Text = "";
        }

        // Tlačítko, kterým mažu data z tabulky Položka
        private void button18_Click(object sender, EventArgs e)
        {
            string obj_id = textBox12.Text;
            string vyrobek_id = textBox11.Text;
            string pocet_ks = textBox10.Text;
            string cena_polozky = textBox9.Text;

            try
            {
                //System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"]) používám pro zjednodušení připojení do databáze pomocí App.config, kde mohu lehce změnit všechny potřebné informace
                using (SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"]))
                {
                    //Kontrola, zda jsem se úspěšně připojil k databázi
                    connection.Open();
                    Console.WriteLine("Pripojeno");

                    //Příkaz DELETE FROM pro smazání dat z tabulky
                    //Zde používám @par pro 'odkazování' na jednotlivé sloupce v tabulce, jako například název, email atd.
                    string query = "DELETE FROM Polozka WHERE obj_id=@par1 OR vyrobek_id=@par2 OR pocet_ks=@par3 OR cena_polozky=@par4";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@par1", obj_id);
                        command.Parameters.AddWithValue("@par2", vyrobek_id);
                        command.Parameters.AddWithValue("@par3", pocet_ks);
                        command.Parameters.AddWithValue("@par4", cena_polozky);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            //Po zmáčknutí tlačítka se text nastaví na prázdný
            textBox12.Text = "";
            textBox11.Text = "";
            textBox10.Text = "";
            textBox9.Text = "";
        }

        // Tlačítko, kterým mažu data z tabulky Objednávka
        private void button17_Click(object sender, EventArgs e)
        {
            string zak_id = textBox16.Text;
            string cis_obj = textBox15.Text;
            string datum = textBox14.Text;
            string cena_objednavky = textBox13.Text;

            try
            {
                //System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"]) používám pro zjednodušení připojení do databáze pomocí App.config, kde mohu lehce změnit všechny potřebné informace
                using (SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"]))
                {
                    //Kontrola, zda jsem se úspěšně připojil k databázi
                    connection.Open();
                    Console.WriteLine("Pripojeno");

                    //Příkaz DELETE FROM pro smazání dat z tabulky
                    //Zde používám @par pro 'odkazování' na jednotlivé sloupce v tabulce, jako například název, email atd.
                    string query = "DELETE FROM Objednavka WHERE zak_id=@par1 OR cis_obj=@par2 OR datum=@par3 OR cena_objednavky=@par4";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@par1", zak_id);
                        command.Parameters.AddWithValue("@par2", cis_obj);
                        command.Parameters.AddWithValue("@par3", datum);
                        command.Parameters.AddWithValue("@par4", cena_objednavky);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            //Po zmáčknutí tlačítka se text nastaví na prázdný
            textBox16.Text = "";
            textBox15.Text = "";
            textBox14.Text = "";
            textBox13.Text = "";
        }

        // Tlačítko, kterým mažu data z tabulky Zákazník
        private void button16_Click(object sender, EventArgs e)
        {
            string prijmeni = textBox20.Text;
            string email = textBox19.Text;

            try
            {
                //System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"]) používám pro zjednodušení připojení do databáze pomocí App.config, kde mohu lehce změnit všechny potřebné informace
                using (SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"]))
                {
                    //Kontrola, zda jsem se úspěšně připojil k databázi
                    connection.Open();
                    Console.WriteLine("Pripojeno");

                    //Příkaz DELETE FROM pro smazání dat z tabulky
                    //Zde používám @par pro 'odkazování' na jednotlivé sloupce v tabulce, jako například název, email atd.
                    string query = "DELETE FROM Zakaznik WHERE prijmeni=@par1 OR email=@par2";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@par1", prijmeni);
                        command.Parameters.AddWithValue("@par2", email);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            //Po zmáčknutí tlačítka se text nastaví na prázdný
            textBox20.Text = "";
            textBox19.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //Proměnné, které zobrazují zprávy pro uživatele
            string message, nadpis, message2, nadpis2;
            object hodnota1, hodnota2;

            message = "Zadejte název výrobce, kterého chcete upravit.";
            nadpis = "Úprava";

            message2 = "Zadejte nový název výrobce.";
            nadpis2 = "Úprava";

            hodnota1 = Interaction.InputBox(message,nadpis);

            try
            {
                //System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"]) používám pro zjednodušení připojení do databáze pomocí App.config, kde mohu lehce změnit všechny potřebné informace
                using (SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"]))
                {
                    //Kontrola, zda jsem se úspěšně připojil k databázi
                    connection.Open();
                    Console.WriteLine("Pripojeno");

                    //Příkaz UPDATE pro úpravu dat v tabulce
                    //Zde používám @par pro 'odkazování' na jednotlivé sloupce v tabulce, jako například název, email atd.
                    string query = "UPDATE Vyrobce SET Nazev=@par1 WHERE Nazev=@par2";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if ((string)hodnota1 != "")
                        {
                            hodnota2 = Interaction.InputBox(message2, nadpis2);

                            command.Parameters.AddWithValue("@par2", hodnota1);
                            command.Parameters.AddWithValue("@par1", hodnota2);
                            command.ExecuteNonQuery();

                            if ((string)hodnota2 == "")
                            {
                                Interaction.MsgBox("Nezadali jste žádný název", MsgBoxStyle.Information, "Špatně");
                            }
                        }
                        else if ((string)hodnota1 == "")
                        {
                            Interaction.MsgBox("Nezadali jste žádný název", MsgBoxStyle.Information, "Špatně");
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        //Button pro ukončení aplikace
        //Uživatel tak může ukončit aplikaci buď křížkem v pravém horním rohu nebo tlačítkem Exit
        private void button2_Click_1(object sender, EventArgs e)
        {
            //Zde pouze zvolím otázku, kterou chci položit uživateli a následně kontroluji zda se jeho odpověď rovná ano nebo ne
            if(MessageBox.Show("Opravdu chcete ukončit aplikaci?","Exit",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Zavření aplikace
                Application.Exit();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Proměnné, které zobrazují zprávy pro uživatele
            string message, nadpis, message2, nadpis2;
            object hodnota1, hodnota2;

            message = "Zadejte název výrobku, který chcete upravit.";
            nadpis = "Úprava";

            message2 = "Zadejte nový název výrobku.";
            nadpis2 = "Úprava";

            hodnota1 = Interaction.InputBox(message, nadpis);

            try
            {
                //System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"]) používám pro zjednodušení připojení do databáze pomocí App.config, kde mohu lehce změnit všechny potřebné informace
                using (SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"]))
                {
                    //Kontrola, zda jsem se úspěšně připojil k databázi
                    connection.Open();
                    Console.WriteLine("Pripojeno");

                    //Příkaz UPDATE pro úpravu dat v tabulce
                    //Zde používám @par pro 'odkazování' na jednotlivé sloupce v tabulce, jako například název, email atd.
                    string query = "UPDATE Vyrobek SET Nazev=@par1 WHERE Nazev=@par2";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if ((string)hodnota1 != "")
                        {
                            hodnota2 = Interaction.InputBox(message2, nadpis2);

                            command.Parameters.AddWithValue("@par2", hodnota1);
                            command.Parameters.AddWithValue("@par1", hodnota2);
                            command.ExecuteNonQuery();

                            if ((string)hodnota2 == "")
                            {
                                Interaction.MsgBox("Nezadali jste žádný název", MsgBoxStyle.Information, "Špatně");
                            }
                        }
                        else if ((string)hodnota1 == "")
                        {
                            Interaction.MsgBox("Nezadali jste žádný název", MsgBoxStyle.Information, "Špatně");
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Proměnné, které zobrazují zprávy pro uživatele
            string message, nadpis, message2, nadpis2;
            object hodnota1, hodnota2;

            message = "Zadejte cenu položky, kterou chcete upravit.";
            nadpis = "Úprava";

            message2 = "Zadejte novou cenu položky.";
            nadpis2 = "Úprava";

            hodnota1 = Interaction.InputBox(message, nadpis);

            try
            {
                //System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"]) používám pro zjednodušení připojení do databáze pomocí App.config, kde mohu lehce změnit všechny potřebné informace
                using (SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"]))
                {
                    //Kontrola, zda jsem se úspěšně připojil k databázi
                    connection.Open();
                    Console.WriteLine("Pripojeno");

                    //Příkaz UPDATE pro úpravu dat v tabulce
                    //Zde používám @par pro 'odkazování' na jednotlivé sloupce v tabulce, jako například název, email atd.
                    string query = "UPDATE Polozka SET cena_polozky=@par1 WHERE cena_polozky=@par2";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if ((string)hodnota1 != "")
                        {
                            hodnota2 = Interaction.InputBox(message2, nadpis2);

                            command.Parameters.AddWithValue("@par2", hodnota1);
                            command.Parameters.AddWithValue("@par1", hodnota2);
                            command.ExecuteNonQuery();

                            if ((string)hodnota2 == "")
                            {
                                Interaction.MsgBox("Nezadali jste žádnou cenu", MsgBoxStyle.Information, "Špatně");
                            }
                        }
                        else if ((string)hodnota1 == "")
                        {
                            Interaction.MsgBox("Nezadali jste žádnou cenu", MsgBoxStyle.Information, "Špatně");
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Proměnné, které zobrazují zprávy pro uživatele
            string message, nadpis, message2, nadpis2;
            object hodnota1, hodnota2;

            message = "Zadejte cenu objednávky, kterou chcete upravit.";
            nadpis = "Úprava";

            message2 = "Zadejte novou cenu objednávky.";
            nadpis2 = "Úprava";

            hodnota1 = Interaction.InputBox(message, nadpis);

            try
            {
                //System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"]) používám pro zjednodušení připojení do databáze pomocí App.config, kde mohu lehce změnit všechny potřebné informace
                using (SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"]))
                {
                    //Kontrola, zda jsem se úspěšně připojil k databázi
                    connection.Open();
                    Console.WriteLine("Pripojeno");

                    //Příkaz UPDATE pro úpravu dat v tabulce
                    //Zde používám @par pro 'odkazování' na jednotlivé sloupce v tabulce, jako například název, email atd.
                    string query = "UPDATE Objednavka SET cena_objednavky=@par1 WHERE cena_objednavky=@par2";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if ((string)hodnota1 != "")
                        {
                            hodnota2 = Interaction.InputBox(message2, nadpis2);

                            command.Parameters.AddWithValue("@par2", hodnota1);
                            command.Parameters.AddWithValue("@par1", hodnota2);
                            command.ExecuteNonQuery();

                            if ((string)hodnota2 == "")
                            {
                                Interaction.MsgBox("Nezadali jste žádnou cenu", MsgBoxStyle.Information, "Špatně");
                            }
                        }
                        else if ((string)hodnota1 == "")
                        {
                            Interaction.MsgBox("Nezadali jste žádnou cenu", MsgBoxStyle.Information, "Špatně");
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Proměnné, které zobrazují zprávy pro uživatele
            string message, nadpis, message2, nadpis2;
            object hodnota1, hodnota2;

            message = "Zadejte e-mail zákazníka, kterého chcete upravit.";
            nadpis = "Úprava";

            message2 = "Zadejte nový zákazníkův e-mail.";
            nadpis2 = "Úprava";

            hodnota1 = Interaction.InputBox(message, nadpis);

            try
            {
                //System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"]) používám pro zjednodušení připojení do databáze pomocí App.config, kde mohu lehce změnit všechny potřebné informace
                using (SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"]))
                {
                    //Kontrola, zda jsem se úspěšně připojil k databázi
                    connection.Open();
                    Console.WriteLine("Pripojeno");

                    //Příkaz UPDATE pro úpravu dat v tabulce
                    //Zde používám @par pro 'odkazování' na jednotlivé sloupce v tabulce, jako například název, email atd.
                    string query = "UPDATE Zakaznik SET email=@par1 WHERE email=@par2";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if ((string)hodnota1 != "")
                        {
                            hodnota2 = Interaction.InputBox(message2, nadpis2);

                            command.Parameters.AddWithValue("@par2", hodnota1);
                            command.Parameters.AddWithValue("@par1", hodnota2);
                            command.ExecuteNonQuery();

                            if ((string)hodnota2 == "")
                            {
                                Interaction.MsgBox("Nezadali jste žádný e-mail", MsgBoxStyle.Information, "Špatně");
                            }
                        }
                        else if ((string)hodnota1 == "")
                        {
                            Interaction.MsgBox("Nezadali jste žádný e-mail", MsgBoxStyle.Information, "Špatně");
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
