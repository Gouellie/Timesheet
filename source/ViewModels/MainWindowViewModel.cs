using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CsvHelper;
using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Timesheet.ViewModels
{
#pragma warning disable CS8618
    internal class MainWindowViewModel : ObservableObject
    {
        private const string INVALID = "<multi-values>";
        public static string VersionString => Version.VersionString;
        public RelayCommand<string> LoadFileCommand { get; }
        public RelayCommand<string> ClearFileCommand { get; }
        public ICommand SwapFilesCommand { get; }
        public ICommand CompareCommand { get; }
        public ICommand SaveUserSettingsCommand { get; }
        public ICommand ExportDiffCommand { get; }
        public ICommand EditExportSettingsCommand { get; }

        public MainWindowViewModel()
        {

        }

        private static bool TryBrowseForFile(out string selectedFilepath)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "csv files (*.csv;*.xlsx)|*.csv;*.xlsx|All files (*.*)|*.*",
                RestoreDirectory = true,
                Multiselect = false,
            };

            if (openFileDialog.ShowDialog() == true)
            {
                selectedFilepath = openFileDialog.FileName;
                return true;
            }

            selectedFilepath = string.Empty;
            return false;
        }

        public static void OpenWithDefaultProgram(string path)
        {
            using var process = new Process();

            process.StartInfo.FileName = "explorer";
            process.StartInfo.Arguments = "\"" + path + "\"";
            process.Start();
        }
    }
#pragma warning restore CS8618
}
