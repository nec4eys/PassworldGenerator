using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassworldGenerator
{
    internal class Presenter
    {
        private IView _view;

        public Presenter(IView view)
        {
            _view = view;

            _view.GenerateTextEvent += GeneratePassworld;
            _view.CopyResultText += CopyPassworld;
        }

        private void GeneratePassworld()
        {
            _view.SetResultText(Logic.GeneratePassworld(_view.PassworldLength, _view.Uppercase, _view.Lowercase, _view.Numbers, _view.Symbol));
        }

        private void CopyPassworld(string passworld)
        {
            Logic.CopyPassworldToClipboard(passworld);
        }
    }
}
