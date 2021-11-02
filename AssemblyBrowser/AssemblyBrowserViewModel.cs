using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using AssemblyBrowserLibrary.AssemblyCompositionElements;
using Microsoft.Win32;

namespace AssemblyBrowser
{
    public class AssemblyBrowserViewModel : INotifyPropertyChanged
    {
        public AssemblyBrowserLibrary.AssemblyBrowser AssemblyBrowser { get; }
        public List<AssemblyContainerInfo> LibAssembly { get; set; }

        public AssemblyBrowserViewModel()
        {
            AssemblyBrowser = new AssemblyBrowserLibrary.AssemblyBrowser();
        }
        
        private AssemblyBrowserCommand _openCommand;
        public AssemblyBrowserCommand OpenCommand
        {
            get
            {
                return _openCommand ??
                       (_openCommand = new AssemblyBrowserCommand(obj =>
                       {
                           try
                           {
                               OpenFileDialog openFileDialog = new OpenFileDialog();
                               if (openFileDialog.ShowDialog() == true)
                               {
                                   var list = AssemblyBrowser.GetNamespace(openFileDialog.FileName);
                                   LibAssembly = new List<AssemblyContainerInfo>();
                                   foreach (var elem in list)
                                   {
                                       LibAssembly.Add(elem);
                                   }
                                   OnPropertyChanged(nameof(LibAssembly));
                               }
                           }
                           catch (Exception e)
                           {
                               MessageBox.Show("failed to load assembly");
                           }
                       }) );
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}