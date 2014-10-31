using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Drawing;

namespace ComputerStore
{
    /// <summary>
    /// This class contains methods and properties related to the login of the user
    /// </summary>
    public class UserLogin
    {

        public string  usernamePasswordMessage = "Username/Password is invalid. \nPlease enter only alphabets or numbers. Username should be at most 15 chars";


        public bool usernamebool = true;
        public bool passwordbool = true;
        public static List<User> userlist;


        /// <summary>
        /// Property to check if username is valid
        /// </summary>
        public bool UsernameValid
        {
            get { return usernamebool; }
            set { usernamebool = value; }
        }

        /// <summary>
        /// Property to check if password is valid
        /// </summary>
        public bool PasswordValid
        {
            get { return passwordbool; }
            set { passwordbool = value; }
        }


        /// <summary>
        /// Property for username and password list
        /// </summary>
        public List<User> UserNameList
        {
            get { return userlist; }
            set { userlist = value; }
        }

        /// <summary>
        /// Constructor of the Login class
        /// </summary>
        public UserLogin()
        {

        }



        /// <summary>
        /// Check Username and password arraylist for Valid User.
        /// </summary>
        /// <param name="user">User containing user and password</param>
        public bool CheckValidUser(User user, List<User> usernamelist)
        {
            if (usernamelist != null)
            {
                for (int i = 0; i < usernamelist.Count; i++)
                {
                    string username = (string)usernamelist[i].Username;
                    string password = (string)usernamelist[i].Password;

                    if (username.Equals(user.Username) && password.Equals(user.Password))
                    {
                        return true;
                    }

                }
            }

                return false;
        }


        /// <summary>
        ///  Checks to make sure the username is valid. Username and password should accept only letters, alphabets,underscore or -. 
        ///  Username and password can be 3-15 digits long
        /// </summary>
        /// <param name="username">Username of the user</param>
        /// <param name="password">Password of the user</param>
        /// <returns></returns>
        public bool UsernamePasswordValidation(string username, string password)
        {
            string regExPattern = "^[a-z0-9_-]{3,15}$";
            
            if (!System.Text.RegularExpressions.Regex.IsMatch(username, regExPattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
            {
                //Username is valid
                UsernameValid = false;

                return UsernameValid;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(password, regExPattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
            {
                //Password is valid
                PasswordValid = true;
                return PasswordValid;
            }
            else
            {
                return true;
            }


        }


        /// <summary>
        /// Serialize a list of users.
        /// </summary>
        /// <param name="userlist">List of users</param>
        public void SerializeLogin(List<User> userlist)
        {
            Stream stream = null;
            try
            {
                
                stream = this.SerializeHelper(userlist, stream);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File is not file " + ex.Message);
            }
            catch (SerializationException ex)
            {
                Console.WriteLine("Failed to serialize. Reason: " + ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception " + ex.Message);
            }
            finally
            {
  
                    stream.Close();
                
            }
        }

        /// <summary>
        /// Serialize the User into a Binary File. 
        /// </summary>
        /// <param name="user">User object that contain user's username and password</param>
        public void SerializeLogin(User user)
        {

            Stream stream=null;           

            List<User> userlist = this.DeserializeLogin();

            try
            {
                if (userlist == null)
                {
                    bool uservalid = this.CheckValidUser(user, userlist);
         
                        if (uservalid == true)
                        {
                            return;
                            //User is already found in userlist on File system. User is not serialized.
                            //Do nothing
                        }
                        else
                        {
                            //User is not found in userlist on File system. User is serialized.
                            userlist = new List<User>();
                            stream=this.SerializeHelper(userlist, stream);
                        }
                    
                }
                else
                {
                    userlist.Add(user);
                    stream = this.SerializeHelper(userlist, stream);


                }
            }
                catch(FileNotFoundException ex)
            {
                Console.WriteLine("File is not file " + ex.Message);
            }
            catch (SerializationException ex)
            {
                Console.WriteLine("Failed to serialize. Reason: " + ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception " + ex.Message);
            }
            finally
            {
  
                    stream.Close();
                
            }
        }
        
        

        /// <summary>
        /// Method to help Serialize a user
        /// </summary>
        /// <param name="userlist">Userlist from the file </param>
        /// <param name="stream">Stream used to create/open file</param>
        /// <returns>Stream used to create/open file</returns>returns>
        public Stream SerializeHelper(List<User> userlist, Stream stream)
        {

            IFormatter formatter = new BinaryFormatter();
            stream = new FileStream("N:/MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, userlist);

            return stream;
        }

        /// <summary>
        /// Deserialized the user.
        /// </summary>
        /// <returns>User object that contain user's username and password</returns>
        public List<User> DeserializeLogin()
        {
            FileStream filestream = null;
            List<User> list = null;
            try
            { 
            filestream = new FileStream("N:/MyFile.bin", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
               object sample =formatter.Deserialize(filestream);

              list = sample as List<User>;
            }
            catch(FileNotFoundException ex)
            {

            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
            }
            catch(IOException ex)
            {
                return null;
            }
            finally
            {
                if (filestream != null)
                {
                    filestream.Close();
                }
            }
            userlist = list;
            return list;

        }


        /// <summary>
        /// Display Username/Password not valid message
        /// </summary>
        /// <param name="ErrorLabel">Label to display message</param>
        public void DisplayInvalidUsernamePasswordMessage(Label ErrorLabel)
        {
            ErrorLabel.Text = this.usernamePasswordMessage;
            ErrorLabel.ForeColor = Color.Red;

            ErrorLabel.Visible = true;
        }

    }

    }

