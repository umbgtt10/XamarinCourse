using Xamarin.Forms;
using XamarinCourse.Advanced.ResourceDictionary;
using XamarinCourse.Advanced.ResourceDictionary.StyleExercise;
using XamarinCourse.DataAccess.Sqlite;
using XamarinCourse.Essentials;
using XamarinCourse.Forms.Exercise;
using XamarinCourse.Layouts.Grid;
using XamarinCourse.Layouts.StackLayout.Exercise1;
using XamarinCourse.Layouts.StackLayout.Exercise2;
using XamarinCourse.Lists;
using XamarinCourse.Lists.Exercise;
using XamarinCourse.Navigation.CustomMasterDetail;
using XamarinCourse.Navigation.Exercise;
using XamarinCourse.Navigation.Hierarchical;
using XamarinCourse.Navigation.Modal;
using XamarinCourse.Navigation.SimpleMasterDetail;
using XamarinCourse.Navigation.SimpleTabbedPage;

namespace XamarinCourse
{
    public class PageFactory
    {
        public Page Build(PageType pageType)
        {
            switch (pageType)
            {
                case PageType.Essentials:
                    return new EssentialsPage();

                case PageType.StackLayoutExercise1:
                    return new StackLayoutExercise1();

                case PageType.StackLayoutExercise2:
                    return new StackLayoutExercise2();

                case PageType.GridLayoutExercise1:
                    return new GridExercise1();

                case PageType.GridLayoutExercise2:
                    return new GridExercise2();

                case PageType.List:
                    return new ListPage();

                case PageType.CustomList:
                    return new CustomListPage();

                case PageType.CustomGroupedList:
                    return new CustomGroupedList();

                case PageType.ContextList:
                    return new ContextActionList();

                case PageType.PullToRefresh:
                    return new PullToRefreshPlusSearchList();

                case PageType.ListExercise:
                    return new AirBnbView();

                case PageType.HierarchicalNavigation:
                    return new NavigationPage(new HierarchicalNavigation())
                    {
                        BackgroundColor = Color.Gray,
                        BarTextColor = Color.Aqua
                    };

                case PageType.ModalNavigation:
                    return new NavigationPage(new ModalNavigation());

                case PageType.CustomMasterDetailNavigation:
                    return new NavigationPage(new CustomMasterDetailPage());

                case PageType.MasterDetailNavigation:
                    return new SimpleMasterDetailPage();

                case PageType.TabbedPageNavigation:
                    return new SimpleTabbedPage();

                case PageType.InstagramTabbedPageExercise:
                    return new NavigationPage(new InstagramTabbedPageExercise());

                case PageType.FormsContactBookExercise:
                    return new ContactBookExercise();

                case PageType.ResourceDictionaryPage:
                    return new ResourceDictionaryPage();

                case PageType.StyleExercise:
                    return new StyleExercise();

                case PageType.PersistencyPage:
                    return new PersistencyPage();
            }

            return null;
        }
    }
}