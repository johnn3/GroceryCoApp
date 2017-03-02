using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ReceiptController
    {
        private Receipt _model;
        private ReceiptView _view;

        public ReceiptController(ReceiptView view, Receipt model)
        {
            _model = model;
            _view = view;
        }
    }
}
