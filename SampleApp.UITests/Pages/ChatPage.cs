using Atata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.UITests.Pages
{
    using _ = ChatPage;

    public class ChatPage : Page<_>
    {
        public H1<_> ChatHeader { get; private set; }
    }
}
