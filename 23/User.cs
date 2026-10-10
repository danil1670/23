using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace _23
{
    public class User : IDataErrorInfo
    {

        public string FIO { get; set; }
        public string Group { get; set; }
        public int? Age { get; set; }
        public string Course { get; set; }

        public string Error => null;

        public string this[string columnName]
        {
            get
            {
                if (columnName == nameof(FIO) && string.IsNullOrWhiteSpace(FIO))
                    return "ФИО не может быть пустым!";

                if (columnName == nameof(Age))
                {
                    if (Age == null)
                        return "Возраст не заполнен!";
                    if (Age < 16 || Age > 70)
                        return "Возраст должен быть от 16 до 70!";
                }
                if (columnName == nameof(Group) && string.IsNullOrWhiteSpace(Group))
                    return "Номер группы не может быть пустым!";

                if (columnName == nameof(Course) && string.IsNullOrWhiteSpace(Course))
                    return "Необходимо выбрать курс!";

                return null;

            }

        }
    }
}
