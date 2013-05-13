using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
        class Program
        {
                static void Main(string[] args)
                {
                        IWindowImplementation macWindowImplementation = new MacWindowImplementation();
                        IWindowImplementation unixWindowImplementation = new UnixWindowImplementation();

                        Window window = new Window(macWindowImplementation);
                        window.DrawText("HeLLo WorLd");
                        window = new Window(unixWindowImplementation);
                        window.DrawText("HeLLo WorLd");

                        IconWindow iconWindow = new IconWindow(macWindowImplementation);
                        iconWindow.DrawIconText("HeLLo WorLd");
                        iconWindow = new IconWindow(unixWindowImplementation);
                        iconWindow.DrawIconText("HeLLo WorLd");
                }
        }
}
