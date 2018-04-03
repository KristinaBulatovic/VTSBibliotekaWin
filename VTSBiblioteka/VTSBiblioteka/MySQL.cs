using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace VTSBiblioteka
{
    class MySQL
    {
        Config config = new Config();
        MySqlConnection conn;
        MySqlCommand cmd;
        public string[] members = new string[7];
        public string[] student = new string[4];
        public string[] book = new string[11];
        public string[] author_sql = new string[5];
        public string[] publisher_sql = new string[7];
        public string[] category_sql = new string[2];
        public string[] rediscover = new string[3];
        public List<string> author = new List<string>();
        public List<string> publisher = new List<string>();
        public List<string> category = new List<string>();
        public List<string> language = new List<string>();
        public List<string> login = new List<string>();
        public List<string> id = new List<string>();

        public void Connection()
        {
            string connString = "Server=" + config.servername + ";Port=" + config.port + ";Database=" + config.db + ";Uid= " + config.username + ";password=" + config.password + ";CharSet=utf8;";
            conn = new MySqlConnection(connString);
            cmd = conn.CreateCommand();
        }

        public bool LoginRead(string username, string password, string table)
        {
            bool result = false;
            cmd.CommandText = "select * from " + table;
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (table == "prijavljivanje")
            {
                while (reader.Read())
                {
                    if (username == reader[1].ToString() && password == reader[2].ToString())
                    {
                        result = true;
                    }
                }
            }
            return result;
        }

        public bool PasswordUpdate(string username, string newPassword, string table)
        {
            try
            {
                cmd.CommandText = "update " + table + " set Lozinka = '" + newPassword + "' where KorisnickoIme = '" + username + "'";
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool BookRead(string udk, string table)
        {
            bool result = false;
            cmd.CommandText = "select * from " + table;
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (table == "knjige")
            {
                while (reader.Read())
                {
                    if (udk == reader[2].ToString())
                    {
                        result = true;
                    }
                }
            }
            else if (table == "knjige_praksa")
            {
                while (reader.Read())
                {
                    if (udk == reader[1].ToString())
                    {
                        result = true;
                    }
                }
            }
            return result;
        }

        public bool AuthorPublisherCategoryLanguageRead(string code, string table)
        {
            bool result = false;
            cmd.CommandText = "select * from " + table;
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (table == "autori" || table == "autori_praksa")
            {
                while (reader.Read())
                {
                    if (code == reader[2].ToString())
                    {
                        result = true;
                    }
                }
            }
            else if (table == "izdavaci" || table == "izdavaci_praksa")
            {
                while (reader.Read())
                {
                    if (code == reader[2].ToString())
                    {
                        result = true;
                    }
                }
            }
            else if (table == "kategorije" || table == "kategorije_praksa")
            {
                while (reader.Read())
                {
                    if (code == reader[2].ToString())
                    {
                        result = true;
                    }
                }
            }
            else if (table == "jezik")
            {
                while (reader.Read())
                {
                    if (code == reader[2].ToString())
                    {
                        result = true;
                    }
                }
            }
            conn.Close();
            return result;
        }

        public bool MembersRead(string membershipCard, string table)
        {
            bool result = false;
            cmd.CommandText = "select * from " + table;
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (membershipCard == reader[1].ToString())
                {
                    result = true;
                }
            }

            return result;
        }

        public bool AuthorRead(string code, string table)
        {
            bool result = false;
            cmd.CommandText = "select * from " + table;
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (table == "autori" || table == "autori_praksa")
            {
                while (reader.Read())
                {
                    if (code == reader[1].ToString())
                    {
                        result = true;
                    }
                }
            }
            return result;
        }

        public bool PublisherRead(string code, string table)
        {
            bool result = false;
            cmd.CommandText = "select * from " + table;
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (table == "izdavaci" || table == "izdavaci_praksa")
            {
                while (reader.Read())
                {
                    if (code == reader[1].ToString())
                    {
                        result = true;
                    }
                }
            }
            return result;
        }

        public bool CategoryRead(string code, string table)
        {
            bool result = false;
            cmd.CommandText = "select * from " + table;
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (table == "kategorije" || table == "kategorije_praksa")
            {
                while (reader.Read())
                {
                    if (code == reader[1].ToString())
                    {
                        result = true;
                    }
                }
            }
            return result;
        }

        public string ReadCode(string name, string table)
        {
            string code = "";
            cmd.CommandText = "select * from " + table;
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (name == reader[2].ToString())
                {
                    code = reader[1].ToString();
                }
            }
            conn.Close();
            return code;
        }

        public string ReadMembershipCard(string indexNum, string table)
        {
            string memCard = "";
            cmd.CommandText = "select * from " + table;
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (indexNum == reader[2].ToString())
                {
                    memCard = reader[1].ToString();
                }
            }
            conn.Close();
            return memCard;
        }

        public string ReadRentalNum(string udk, string table)
        {
            string rentalNum = "";
            cmd.CommandText = "select * from " + table;
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (udk == reader[1].ToString())
                {
                    rentalNum = reader[2].ToString();
                }
            }
            conn.Close();
            return rentalNum;
        }

        public bool InsertMembers(string membershipCard, string indexNumber, string firstName, string lastName, string address, string email, string phoneNumber, string table)
        {
            try
            {
                cmd.CommandText = "insert into " + table + " (ClanskaKarta, BrojIndeksa, Ime, Prezime, Adresa, Email, Telefon) values ('" + membershipCard + "', '" + indexNumber + "', '" + firstName + "', '" + lastName + "', '" + address + "', '" + email + "', '" + phoneNumber + "')";
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool InsertBook(string inventoryNum, string udk, string isbn, string name, string yearPublication, string author, string publisher, string category, string language, string state, string note, string table)
        {
            try
            {
                if (table == "knjige")
                {
                    string author_code = ReadCode(author, "autori");
                    string publisher_code = ReadCode(publisher, "izdavaci");
                    string category_code = ReadCode(category, "kategorije");
                    string language_code = ReadCode(language, "jezik");
                    cmd.CommandText = "insert into " + table + " (InventarniBroj, UDKBroj, ISBNBroj, Naslov, GodinaIzdanja, SifraAutora, SifraIzdavaca, SifraKategorije, SifraJezika, Stanje, Napomena) values ('" + inventoryNum + "', '" + udk + "', '" + isbn + "', '" + name + "', '" + yearPublication + "', '" + author_code + "', '" + publisher_code + "', '" + category_code + "', '" + language_code + "', " + state + ", '" + note + "')";
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                }
                else if (table == "knjige_praksa")
                {
                    string author_code = ReadCode(author, "autori_praksa");
                    string publisher_code = ReadCode(publisher, "izdavaci_praksa");
                    string category_code = ReadCode(category, "kategorije_praksa");
                    string language_code = ReadCode(language, "jezik");
                    cmd.CommandText = "insert into " + table + " (InventarniBroj, UDKBroj, ISBNBroj, Naslov, GodinaIzdanja, SifraAutora, SifraIzdavaca, SifraKategorije, SifraJezika, Stanje, Napomena) values ('" + inventoryNum + "', '" + udk + "', '" + isbn + "', '" + name + "', '" + yearPublication + "', '" + author_code + "', '" + publisher_code + "', '" + category_code + "', '" + language_code + "', " + state + ", '" + note + "')";
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool InsertAuthor(string code, string name, string country, string years, string note, string table)
        {
            try
            {
                if (code != "" && name != "")
                {
                    cmd.CommandText = "insert into " + table + " (Sifra, ImePrezime, Zemlja, Godina, Napomena) values ('" + code + "', '" + name + "', '" + country + "', '" + years + "', '" + note + "')";
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    return true;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool InsertPublisher(string code, string name, string location, string address, string phone, string web, string email, string table)
        {
            try
            {
                if (code != "" && name != "")
                {
                    cmd.CommandText = "insert into " + table + " (Sifra, Naziv, Mesto, Adresa, Telefon, Web, Email) values ('" + code + "', '" + name + "', '" + location + "', '" + address + "', '" + phone + "', '" + web + "', '" + email + "')";
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    return true;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool InsertStatistic(string udk, string rentalNum, string table)
        {
            try
            {
                cmd.CommandText = "insert into " + table + " (UDKBroj, BrojIznajmljivanja) values ('" + udk + "', " + rentalNum + ")";
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool InsertCategory(string code, string name, string table)
        {
            try
            {
                if (code != "" && name != "")
                {
                    cmd.CommandText = "insert into " + table + " (Sifra, Naziv) values ('" + code + "', '" + name + "')";
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    return true;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteBook(string udk, string table)
        {
            try
            {
                if (table == "knjige")
                {
                    cmd.CommandText = "delete from " + table + " where UDKBroj = " + udk;
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                }
                else if (table == "knjige_praksa")
                {
                    cmd.CommandText = "delete from " + table + " where InventarniBroj = " + udk;
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCode(string code, string table)
        {
            try
            {
                cmd.CommandText = "delete from " + table + " where Sifra = " + code;
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteMembers(string membershipCard, string table)
        {
            try
            {
                cmd.CommandText = "delete from " + table + " where ClanskaKarta = '" + membershipCard + "'";
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ReadMembers(string memCardIndexNum, string table, string search)
        {
            bool result = false;
            members[0] = "";
            members[1] = "";
            members[2] = "";
            members[3] = "";
            members[4] = "";
            members[5] = "";
            members[6] = "";
            cmd.CommandText = "select * from clanovi";
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (table == "clanovi")
            {
                while (reader.Read())
                {
                    if (search == "MembershipCard")
                    {
                        if (memCardIndexNum == reader[1].ToString())
                        {
                            members[0] = reader[1].ToString();
                            members[1] = reader[2].ToString();
                            members[2] = reader[3].ToString();
                            members[3] = reader[4].ToString();
                            members[4] = reader[5].ToString();
                            members[5] = reader[6].ToString();
                            members[6] = reader[7].ToString();
                            result = true;
                        }
                    }
                    else if (search == "IndexNumber")
                    {
                        if (memCardIndexNum == reader[2].ToString())
                        {
                            members[0] = reader[1].ToString();
                            members[1] = reader[2].ToString();
                            members[2] = reader[3].ToString();
                            members[3] = reader[4].ToString();
                            members[4] = reader[5].ToString();
                            members[5] = reader[6].ToString();
                            members[6] = reader[7].ToString();
                            result = true;
                        }
                    }
                }
            }
            return result;
        }

        public bool ReadStudent(string memCardIndexNum, string table, string search)
        {
            bool result = false;
            members[0] = "";
            members[1] = "";
            members[2] = "";
            members[3] = "";
            cmd.CommandText = "select * from clanovi";
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (table == "clanovi")
            {
                while (reader.Read())
                {
                    if (search == "MembershipCard")
                    {
                        if (memCardIndexNum == reader[1].ToString())
                        {
                            members[0] = reader[1].ToString();
                            members[1] = reader[2].ToString();
                            members[2] = reader[3].ToString();
                            members[3] = reader[4].ToString();
                            result = true;
                        }
                    }
                    else if (search == "IndexNumber")
                    {
                        if (memCardIndexNum == reader[2].ToString())
                        {
                            members[0] = reader[1].ToString();
                            members[1] = reader[2].ToString();
                            members[2] = reader[3].ToString();
                            members[3] = reader[4].ToString();
                            result = true;
                        }
                    }
                }
            }
            return result;
        }


        public bool ReadRediscover(string memCardIndexNum, string table, string search)
        {
            bool result = false;
            rediscover[0] = "";
            rediscover[1] = "";
            rediscover[2] = "";
            cmd.CommandText = "select c.ClanskaKarta, c.BrojIndeksa, k.UDKBroj from zaduzivanje_knjiga as zk inner join clanovi as c on zk.ClanskaKarta = c.ClanskaKarta inner join knjige as k on zk.UDKBroj = k.UDKBroj";
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (table == "zaduzivanje_knjiga")
            {
                while (reader.Read())
                {
                    if (search == "MembershipCard")
                    {
                        if (memCardIndexNum == reader[0].ToString())
                        {
                            rediscover[0] = reader[0].ToString();
                            rediscover[1] = reader[1].ToString();
                            rediscover[2] = reader[2].ToString();
                            result = true;
                        }
                    }
                    else if (search == "IndexNumber")
                    {
                        if (memCardIndexNum == reader[1].ToString())
                        {
                            rediscover[0] = reader[0].ToString();
                            rediscover[1] = reader[1].ToString();
                            rediscover[2] = reader[2].ToString();
                            result = true;
                        }
                    }
                }
            }
            return result;
        }

        public bool ReadBook(string udk, string table)
        {
            bool result = false;
            book[0] = "";
            book[1] = "";
            book[2] = "";
            book[3] = "";
            book[4] = "";
            book[5] = "";
            book[6] = "";
            book[7] = "";
            book[8] = "";
            book[9] = "";
            book[10] = "";
      
            if (table == "knjige")
            {
                cmd.CommandText = "select knjige.InventarniBroj, knjige.UDKBroj, knjige.ISBNBroj, knjige.Naslov, knjige.GodinaIzdanja , autori.ImePrezime, izdavaci.Naziv, kategorije.Naziv, jezik.Naziv, knjige.Stanje, knjige.Napomena from knjige inner join autori on knjige.SifraAutora = autori.Sifra inner join izdavaci on knjige.SifraIzdavaca = izdavaci.Sifra inner join kategorije on knjige.SifraKategorije = kategorije.Sifra inner join jezik on knjige.SifraJezika = jezik.Sifra";
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (udk == reader[1].ToString())
                    {
                        book[0] = reader[0].ToString();
                        book[1] = reader[1].ToString();
                        book[2] = reader[2].ToString();
                        book[3] = reader[3].ToString();
                        book[4] = reader[4].ToString();
                        book[5] = reader[5].ToString();
                        book[6] = reader[6].ToString();
                        book[7] = reader[7].ToString();
                        book[8] = reader[8].ToString();
                        book[9] = reader[9].ToString();
                        book[10] = reader[10].ToString();
                        result = true;
                    }
                }
            }

            else if (table == "knjige_praksa")
            {
                cmd.CommandText = "select knjige_praksa.InventarniBroj, knjige_praksa.UDKBroj, knjige_praksa.ISBNBroj, knjige_praksa.Naslov, knjige_praksa.GodinaIzdanja , autori_praksa.ImePrezime, izdavaci_praksa.Naziv, kategorije_praksa.Naziv, jezik.Naziv, knjige_praksa.Stanje, knjige_praksa.Napomena from knjige_praksa inner join autori_praksa on knjige_praksa.SifraAutora = autori_praksa.Sifra inner join izdavaci_praksa on knjige_praksa.SifraIzdavaca = izdavaci_praksa.Sifra inner join kategorije_praksa on knjige_praksa.SifraKategorije = kategorije_praksa.Sifra inner join jezik on knjige_praksa.SifraJezika = jezik.Sifra";
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (udk == reader[0].ToString())
                    {
                        book[0] = reader[0].ToString();
                        book[1] = reader[1].ToString();
                        book[2] = reader[2].ToString();
                        book[3] = reader[3].ToString();
                        book[4] = reader[4].ToString();
                        book[5] = reader[5].ToString();
                        book[6] = reader[6].ToString();
                        book[7] = reader[7].ToString();
                        book[8] = reader[8].ToString();
                        book[9] = reader[9].ToString();
                        book[10] = reader[10].ToString();
                        result = true;
                    }
                }
            }
            return result;
        }

        public bool ReadAuthor(string code, string table)
        {
            bool result = false;
            author_sql[0] = "";
            author_sql[1] = "";
            author_sql[2] = "";
            author_sql[3] = "";
            author_sql[4] = "";
            cmd.CommandText = "select * from " + table;
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (table == "autori" || table == "autori_praksa")
            {
                while (reader.Read())
                {
                    if (code == reader[1].ToString())
                    {
                        author_sql[0] = reader[1].ToString();
                        author_sql[1] = reader[2].ToString();
                        author_sql[2] = reader[3].ToString();
                        author_sql[3] = reader[4].ToString();
                        author_sql[4] = reader[5].ToString();
                        result = true;

                    }
                }
            }
            return result;
        }

        public bool ReadPublisher(string code, string table)
        {
            bool result = false;
            publisher_sql[0] = "";
            publisher_sql[1] = "";
            publisher_sql[2] = "";
            publisher_sql[3] = "";
            publisher_sql[4] = "";
            publisher_sql[5] = "";
            publisher_sql[6] = "";
            cmd.CommandText = "select * from " + table;
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (table == "izdavaci" || table == "izdavaci_praksa")
            {
                while (reader.Read())
                {
                    if (code == reader[1].ToString())
                    {
                        publisher_sql[0] = reader[1].ToString();
                        publisher_sql[1] = reader[2].ToString();
                        publisher_sql[2] = reader[3].ToString();
                        publisher_sql[3] = reader[4].ToString();
                        publisher_sql[4] = reader[5].ToString();
                        publisher_sql[5] = reader[6].ToString();
                        publisher_sql[6] = reader[7].ToString();
                        result = true;

                    }
                }
            }
            return result;
        }

        public bool ReadCategory(string code, string table)
        {
            bool result = false;
            category_sql[0] = "";
            category_sql[1] = "";
            cmd.CommandText = "select * from " + table;
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (table == "kategorije" || table == "kategorije_praksa")
            {
                while (reader.Read())
                {
                    if (code == reader[1].ToString())
                    {
                        category_sql[0] = reader[1].ToString();
                        category_sql[1] = reader[2].ToString();
                        result = true;
                    }
                }
            }
            return result;
        }

        public bool UpdateMembers(string membershipCard, string indexNumber, string firstName, string lastName, string address, string email, string phoneNumber, string table)
        {
            try
            {
                cmd.CommandText = "update " + table + " set ClanskaKarta = '" + membershipCard + "', BrojIndeksa = '" + indexNumber + "', Ime = '" + firstName + "', Prezime = '" + lastName + "', Adresa = '" + address + "', Email = '" + email + "', Telefon = '" + phoneNumber + "' where ClanskaKarta = '" + membershipCard + "'";
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateStatistic(string udk, string rentalNum, string table)
        {
            try
            {
                cmd.CommandText = "update " + table + " set BrojIznajmljivanja = " + rentalNum + " where UDKBroj = " + udk;
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateBook(string inventoryNum, string udk, string isbn, string name, string yearPublication, string author, string publisher, string category, string language, string state, string note, string table)
        {
            try
            {
                string author_code;
                string publisher_code;
                string category_code;
                string language_code;

                if (table == "knjige")
                {
                    author_code = ReadCode(author, "autori");
                    publisher_code = ReadCode(publisher, "izdavaci");
                    category_code = ReadCode(category, "kategorije");
                    language_code = ReadCode(language, "jezik");

                    cmd.CommandText = "update " + table + " set InventarniBroj= '" + inventoryNum + "', ISBNBroj= '" + isbn + "', Naslov = '" + name + "', GodinaIzdanja = '" + yearPublication + "', SifraAutora = '" + author_code + "', SifraIzdavaca = '" + publisher_code + "', SifraKategorije = '" + category_code + "', SifraJezika = '" + language_code + "', Stanje = " + state + ", Napomena = '" + note + "' where UDKBroj = '" + udk + "'";
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                }
                else if(table == "knjige_praksa")
                {
                    author_code = ReadCode(author, "autori_praksa");
                    publisher_code = ReadCode(publisher, "izdavaci_praksa");
                    category_code = ReadCode(category, "kategorije_praksa");
                    language_code = ReadCode(language, "jezik");

                    cmd.CommandText = "update " + table + " set UDKBroj= '" + udk + "', ISBNBroj = '" + isbn + "', Naslov = '" + name + "', GodinaIzdanja = '" + yearPublication + "', SifraAutora = '" + author_code + "', SifraIzdavaca = '" + publisher_code + "', SifraKategorije = '" + category_code + "', SifraJezika = '" + language_code + "', Stanje = " + state + ", Napomena = '" + note + "' where InventarniBroj = '" + inventoryNum + "'";
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateAuthor(string code, string name, string country, string years, string note, string table)
        {
            try
            {
                cmd.CommandText = "update " + table + " set ImePrezime = '" + name + "', Zemlja = '" + country + "', Godina = '" + years + "', Napomena = '" + note + "' where Sifra = '" + code + "'";
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdatePublisher(string code, string name, string location, string address, string phone, string web, string email, string table)
        {
            try
            {
                cmd.CommandText = "update " + table + " set Naziv = '" + name + "', Mesto = '" + location + "', Adresa = '" + address + "', Telefon = '" + phone + "', Web = '" + web + "', Email = '" + email + "' where Sifra = '" + code + "'";
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateCategory(string code, string name, string table)
        {
            try
            {
                cmd.CommandText = "update " + table + " set Naziv = '" + name + "' where Sifra = '" + code + "'";
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool InsertBorrowingBooks(string membershipCard, string udk, string dateBorrowing, string dateReturn, string table)
        {
            try
            {
                cmd.CommandText = "insert into " + table + " (ClanskaKarta, UDKBroj, DatumZaduzivanja, DatumVracanja) values ('" + membershipCard + "', '" + udk + "' , '" + dateBorrowing + "', '" + dateReturn + "')";
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteBorrowStudent(string id, string table) {
            try
            {
                cmd.CommandText = "delete from " + table + " where ID = " + id;
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string ReadState(string udk, string table)
        {
            string result = "";
            cmd.CommandText = "select * from " + table;
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (table == "knjige")
            {
                while (reader.Read())
                {
                    if (udk == reader[2].ToString())
                    {
                        result = reader[10].ToString();
                    }
                }
            }
            return result;
        }

        public void UpdateBookState(string udk, string state, string table)
        {
            cmd.CommandText = "update " + table + " set Stanje = " + state + " where UDKBroj = " + udk;
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
        }

        public string IDMembersRead(string membershipCard, string udk, string table)
        {
            string result = "";
            cmd.CommandText = "select * from " + table;
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (table == "zaduzivanje_knjiga")
            {
                while (reader.Read())
                {
                    if (membershipCard == reader[1].ToString() && udk == reader[2].ToString())
                    {
                        result = reader[0].ToString();
                    }
                }
            }
            return result;
        }

        public void ReadTable(string orderBy, string table)
        {
            cmd.CommandText = "select * from " + table + " ORDER BY " + orderBy + " asc";
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (table == "autori" || table == "autori_praksa")
            {
                author.Clear();
                while (reader.Read())
                {
                    author.Add(reader[2].ToString());
                }
            }
            else if (table == "izdavaci" || table == "izdavaci_praksa")
            {
                publisher.Clear();
                while (reader.Read())
                {
                    publisher.Add(reader[2].ToString());
                }
            }
            else if (table == "kategorije" || table == "kategorije_praksa")
            {
                category.Clear();
                while (reader.Read())
                {
                    category.Add(reader[2].ToString());
                }
            }
            else if (table == "jezik")
            {
                language.Clear();
                while (reader.Read())
                {

                    language.Add(reader[2].ToString());
                }
            }
            else if (table == "prijavljivanje")
            {
                login.Clear();
                while (reader.Read())
                {

                    login.Add(reader[1].ToString());
                }
            }
        }

        public void ReadID(string table)
        {
            cmd.CommandText = "select ID from " + table;
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            id.Clear();
            while (reader.Read())
            {
                id.Add(reader[0].ToString());
            }
            conn.Close();
        }

        public void Statistic(string udk, string table)
        {
            try
            {
                string result = ReadRentalNum(udk, table);
                if (result != "")
                {
                    int rentalNum = Convert.ToInt32(result) + 1;
                    UpdateStatistic(udk, Convert.ToString(rentalNum), table);
                }
                else
                {
                    InsertStatistic(udk, "1", table);
                }
            }
            catch
            {
                //Error!
            }
        }
        
        public string EmptyAllRows(string table)
        {
            try
            {
                ReadID(table);
                for (int i = 0; i < id.Count; i++)
                {
                    cmd.CommandText = "delete from " + table + " where ID = " + id[i];
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    conn.Close();
                }
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
          
        }

        public void Close()
        {
            conn.Close();
        }
    }
}
