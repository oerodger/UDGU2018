using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Models
{
    public class MainRepository
    {
        private List<Ingridient> ingridients = new List<Ingridient>();
        private List<Recipe> recipes = new List<Recipe>();

        /// <summary>
        /// Инициализация репозитория
        /// </summary>
        public void Init()
        {
            var dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plugins");
            foreach (var path in Directory.GetFiles(dir, "*.dll"))
            {
                var asm = Assembly.LoadFile(path);
                ingridients.AddRange(CollectTypes<Ingridient, IngridientAttribute>(asm));
                recipes.AddRange(CollectTypes<Recipe, RecipeAttribute>(asm));
            }
        }

        /// <summary>
        /// Сборка экземпляров типа по атрибутам
        /// </summary>
        /// <typeparam name="T">Тип собираемых экземпляров</typeparam>
        /// <typeparam name="TA">Атрибут, которым помечаются типы</typeparam>
        /// <param name="asm"></param>
        /// <returns></returns>
        public List<T> CollectTypes<T, TA>(Assembly asm)
            where TA: Attribute
        {
            var res = new List<T>();

            foreach (var type in asm.GetTypes())
            {
                var attr = type.GetCustomAttribute<TA>();
                if (attr != null)
                {
                    res.Add((T)Activator.CreateInstance(type));
                }
            }

            return res;
        }

        /// <summary>
        /// Получить все рецепты
        /// </summary>
        /// <returns></returns>
        public List<Recipe> FindAllRecipes()
        {
            return recipes;
        }

        /// <summary>
        /// Получить все ингридиенты
        /// </summary>
        /// <returns></returns>
        public List<Ingridient> FindAllIngridients()
        {
            return ingridients;
        }
    }
}
