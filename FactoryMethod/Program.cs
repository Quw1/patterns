using System;
namespace FactoryMethodExample
{
    //абстрактний клас творця, який має абстрактний метод FactoryMethod, що приймає тип продукта
    public abstract class Publisher
    {
        public abstract PressMaterial DetermineMaterialType(int type);
    }

    public class OxfordPressPublisher : Publisher
    {
        public override PressMaterial DetermineMaterialType(int type)
        {
            switch (type)
            {

                case 1: return new PressMaterialTypeNewspaper();
                case 2: return new PressMaterialTypeOnline();
                case 3: return new PressMaterialTypeVideo();
                default: throw new ArgumentException("Invalid material type.", "type");
            }
        }
    }

    public abstract class PressMaterial
    {
        public abstract string PublishMaterial();
    } //абстрактний клас продукт

    //конкретні продукти з різною реалізацією
    public class PressMaterialTypeNewspaper : PressMaterial
    {

        public override string PublishMaterial()
        {
            return "Printing this material for newspaper";
        }
    }

    public class PressMaterialTypeOnline : PressMaterial
    {

        public override string PublishMaterial()
        {
            return "Published this material on website";
        }
    }

    public class PressMaterialTypeVideo : PressMaterial
    {

        public override string PublishMaterial()
        {
            return "Published this material on Youtube channel";
        }
    }

    class MainApp
    {
        static void Main()
        {       //створюємо творця
            Publisher oxfordPressInstance = new OxfordPressPublisher();
            for (int i = 1; i <= 3; i++)
            {
                //створюємо спочатку продукт з типом 1, потім з типом 2
                var product = oxfordPressInstance.DetermineMaterialType(i);
                Console.WriteLine(product.PublishMaterial());
            }
            Console.ReadKey();
        }
    }
}
