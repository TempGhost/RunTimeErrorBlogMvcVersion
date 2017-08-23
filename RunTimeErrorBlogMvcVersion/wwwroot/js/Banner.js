var CurrBannerHeight = 0;//当前页面Banner高度
var CurrScrollLocal = 0;//轮询赋值对象 当前滚动条位置
var BannerState = 0;//Banner 状态标识
var CurrScreenX = 0;// 当前屏幕底线位置
var CurrBottomHeight = 0;
var CurrScrollHeight = 0;
var LeftBannerState = 0; 


function SandJumpUrl(url) {
    window.location = '/'+url;
}
$(document).ready(function () {



    //$.ajax({
    //    type:'Get',
    //    url: 'http://' + document.domain+'/Home/Banner',
    //    dataType:'html',
    //    success:function(data){
    //        $("#MoveingBanner").append(data);

    //    }
    //});

            InitLoginBlock();
            SetLetSideBannerUp();
            inItGhostChat("Chating", "GhostChatContent");

    CurrBannerHeight = $("#MoveingBanner").eq(0).css("height").replace("px", "");
  //  CurrBottomHeight == $("#MovingBottom").eq(0).css("height").replace("px", "");
    //$("#MoveingBanner").css("line-height", CurrBannerHeight+"px");
 //   $("#MovingBottom").css({ "position": "fixed", "bottom": 0   + "px" });
});
function BannerPolling() {
    //console.log(CurrScrollLocal - CurrBannerHeight.replace('px', ''));
    CurrScrollLocal = (document.documentElement.scrollTop > 0) ? document.documentElement.scrollTop  //IE mode this mothed return 0
    : (document.body.scrollTop > 0) ? document.body.scrollTop : 0;
    CurrScrollHeight = (document.documentElement.scrollHeight > 0) ? document.documentElement.scrollHeight  //IE mode this mothed return 0
    : (document.body.scrollHeight > 0) ? document.body.scrollHeight : 0; 
    if (CurrScrollLocal - CurrBannerHeight.replace('px', '')-20 > 0) {
        // $(".Banner").css("display", "none").css({ "position": "fixe", "top": CurrScrollLocal }).slideDown();

        if ($("#MoveingBanner").css("position") != "fixed") {
            //  $("#MoveingBanner").css("heiht", "0px");
            //     $("#MovingBottom").css({ "position": "fixed", top: CurrScrollLocal*2.6666666+ "px" });
            $("#MoveingBanner").css({ "position": "fixed", top: 0 + "px", left: "0px" });
            ShowLeftSideBanner();
          //- CurrBannerHeight+"px" 

          //  $("#MoveingBanner").animate("height", CurrBannerHeight+"px");
        }
     //   $("#MovingBottom").css({ "line-height": CurrBannerHeight * 0.55 + "px", "z-index": "9999" });
        $("#MoveingBanner").css({ "z-index": "9999"});//animate , "line-height": CurrBannerHeight * 0.55 + "px"

       // console.log(CurrScrollLocal);
        //$("#MoveingBanner").css({ "top":"0px"}, 300);
        //$("#MoveingBanner").css({ "top": CurrScrollLocal }, 300);
    } else if (CurrScrollLocal - CurrBannerHeight.replace('px', '') < 0) {
        HideLeftSideBanner();
            $("#MoveingBanner").css({ "position": "", "top": CurrScrollLocal});// "line-height": CurrBannerHeight + "px"  
       // $("#MovingBottom").css({ "position": "absolute", top: "" });
    }
    //console.log(CurrScrollHeight);
    if (CurrScrollHeight - CurrScrollLocal < 700) {
         $("#MovingBottom").css({ "position": ";","line-height": CurrBannerHeight});
            //alert(1);
    }
    setTimeout(BannerPolling, 100);
}
function SetLetSideBannerUp()
{
    $("#ScrollUp").on('click', function () {
        HideLeftSideBanner();
    }); 
}
function ShowLeftSideBanner()
{
    if (LeftBannerState==0) {
        $(".LeftSideBanner").animate({ 'left': "0px" });
        LeftBannerState = 1;
    } 
}
function HideLeftSideBanner()
{
    if (LeftBannerState == 1) {
        $(".LeftSideBanner").animate({ 'left': "-300px" });
        LeftBannerState = 0;
    }
   
}