using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace UtiCompanion.Model
{
    class Uti
    {
       string UtiName { get; set; }
       List<Spec> spec = new List<Spec>(); // Список особенностей утилиты
       public int currentSpec = 0; // Переменная, отвечающая за текущую утилиту

        public Uti (string utiName)
        {
            this.UtiName = utiName;
        }


        //Нестед класс, содержащий в себе особенность утилиты, состоящий из названия особенности и её описания
       public class Spec {
            public string SpecName { get; set; }
            public string SpecDescr { get; set; }

            public Spec()
            {
                this.SpecName = "Введите название";
                this.SpecDescr = "Введите описание";
            }
            public Spec(string specname)
            {
                this.SpecName = specname;
                this.SpecDescr = "Введите описание";
            }
            public Spec (string specname, string specdescr)
            {
                this.SpecName = specname;
                this.SpecDescr = specdescr;
            }

            // Переименовать особенность
            public void RenameSpec(string specName)
            {
                this.SpecName = specName;
            }

            // Изменить описание
            public void ChangeDescr(string descr)
            {
                this.SpecDescr = descr;
            }
        }

        // Добавить особенность
       public void AddSpec ()
        {
            Spec spec = new Spec();
            this.spec.Add(spec);
        }

        public void AddSpec(string specname, string specdescr)
        {
            Spec spec = new Spec(specname, specdescr);
            this.spec.Add(spec);
        }

        // Удалить особенность
       public void RemoveSpec(Spec spec)
        {
            this.spec.Remove(spec);
        }

        // Получить текущую особенность
        public Spec ReturnCurrentSpec ()
        {
            Spec spec = this.spec[currentSpec];
            return spec;
        }

        // Перейти к следующей особенности
        public void PlusCurrentSpec()
        {
            if (currentSpec < spec.Count-1)
            {
                currentSpec++;
            }
            else 
            {
                currentSpec = spec.Count-1;
            }
        }

        // Перейти к предыдущей особенности
        public void MinusCurrentSpec()
        {
            if (currentSpec > 0)
            {
                currentSpec--;
            }
            else if (currentSpec <= 0)
            {
                currentSpec = 0;
            }
        }
    }
}
