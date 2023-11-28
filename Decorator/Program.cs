using System;
namespace Decorator.Examples
{
    class MainApp
    {
        static void Main()
        {
            // Create ConcreteComponent and two Decorators
            ConcreteComponent c = new ConcreteComponent();
            ChrismasToysDecorator d1 = new ChrismasToysDecorator();
            ChristmasLightsDecorator d2 = new ChristmasLightsDecorator();

            // Link decorators
            d1.SetComponent(c);
            d2.SetComponent(d1);

            d2.Operation();

            // Wait for user
            Console.Read();
        }
    }
    // "Component"
    abstract class Component
    {
        public abstract void Operation();
    }

    // "ConcreteComponent"
    class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("Christmas Tree");
        }
    }
    // "Decorator"
    abstract class Decorator : Component
    {
        protected Component component;

        public void SetComponent(Component component)
        {
            this.component = component;
        }
        public override void Operation()
        {
            if (component != null)
            {
                component.Operation();
            }
        }
    }

    // "ConcreteDecoratorA"
    class ChrismasToysDecorator : Decorator
    {
        private int ballsNum;
        public override void Operation()
        {
            base.Operation();
            ballsNum = 99;
            Console.WriteLine($"With {ballsNum} toys");

        }
    }

    // "ConcreteDecoratorB" 
    class ChristmasLightsDecorator : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            LightsOn();

        }
        void LightsOn()
        {
            Console.WriteLine("3.. 2.. 1.. Lights on!");
            Console.Write("          *             ,\r\n                       _/^\\_\r\n                      <     >\r\n     *                 /.-.\\         *\r\n              *        `/&\\`                   *\r\n                      ,@.*;@,\r\n                     /_o.I %_\\    *\r\n        *           (`'--:o(_@;\r\n                   /`;--.,__ `')             *\r\n                  ;@`o % O,*`'`&\\\r\n            *    (`'--)_@ ;o %'()\\      *\r\n                 /`;--._`''--._O'@;\r\n                /&*,()~o`;-.,_ `\"\"`)\r\n     *          /`,@ ;+& () o*`;-';\\\r\n               (`\"\"--.,_0 +% @' &()\\\r\n               /-.,_    ``''--....-'`)  *\r\n          *    /@%;o`:;'--,.__   __.'\\\r\n              ;*,&(); @ % &^;~`\"`o;@();         *\r\n              /(); o^~; & ().o@*&`;&%O\\\r\n        jgs   `\"=\"==\"\"==,,,.,=\"==\"===\"`\r\n           __.----.(\\-''#####---...___...-----._\r\n         '`         \\)_`\"\"\"\"\"`\r\n                 .--' ')\r\n               o(  )_-\\\r\n                 `\"\"\"` `\r\n"); ;

        }
    }
}