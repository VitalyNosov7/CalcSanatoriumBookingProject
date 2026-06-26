using WPFCSB.ViewModels.Base;

namespace WPFCSB.ViewModels
{

    // TODO: Класс нигде пока не используется.
    public class TabItemViewModel : ViewModelBase
    {

        private String? _header;
        public String Header
        {
            get => _header!;
            set => Set(ref _header, value);
        }


        private String? _content;
        public String Content
        {
            get => _content!;
            set => Set(ref _content, value);
        }
    }
}
