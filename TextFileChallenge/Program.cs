using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFileChallenge
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ChallengeForm());

            //SaveUserModelListToFile(@"F:\Weekly Challenges\WriteToTextFile\TextFileChallenge\TestExample.csv", userModels);

            //foreach (UserModel u in userModels)
            //{
            //    Console.WriteLine($"Name: {u.FirstName} {u.LastName}\nAge: {u.Age}\nIs Alive: {u.IsAlive}");
            //}
        }

        

        public static void SaveUserModelListToFile(string directory, List<UserModel> userModels)
        {
            Type type = typeof(UserModel);
            var props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance).OrderBy(p => p.Name);

            using (var writer = new StreamWriter(@"" + directory))
            {
                writer.WriteLine(string.Join(", ", props.Select(p => p.Name)));

                foreach (UserModel u in userModels)
                {
                    writer.WriteLine(string.Join(", ", props.Select(p => p.GetValue(u, null))));

                }

            }



        }

    }
}
