using DPTIS_XamarinF_PR2.Models;
using DPTIS_XamarinF_PR2.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace DPTIS_XamarinF_PR2.ViewModels
{
    public class DetailsViewModel
    {
        public ObservableCollection<PracticeItem> Items { get; set; }

        public DetailsViewModel()
        {
            Items = new ObservableCollection<PracticeItem>()
            {
                new PracticeItem{ Title = "Xamarin 빠른 시작", Description="Xamarin.Forms를 사용하여 모바일 애플리케이션을 만드는 방법 실습", Date="2019/07/03", Page=new NotesPage()},
                new PracticeItem{ Title = "페이지 컨트롤 실습", Description="플랫폼 간 모바일 응용 프로그램 화면을 표시하는 Page에 대해 살펴봅니다", Date="2019/09/25", Page=new PagePR_Page()},
                new PracticeItem{ Title = "레이아웃 컨트롤 실습", Description="시각적 구조로 사용자 인터페이스 컨트롤들을 작성하는데 사용되는 Layout에 대해 살펴봅니다", Date="2019/09/26", Page=new LayoutPR_Page()},
                new PracticeItem{ Title = "뷰 컨트롤 실습", Description="플랫폼 간 모바일 사용자 인터페이스의 구성요소인 View에 대해 살펴봅니다", Date="2019/09/27", Page=new ViewPR_Page()}
            };
        }
    }
}
