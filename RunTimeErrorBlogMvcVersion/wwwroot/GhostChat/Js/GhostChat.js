var CurrFunctionTap = "GhostChatingContent";
$(document).ready(function () {
    inItGhostChat("Chating", "GhostChatContent");
});


function inItGhostChat(delegate,Content) {
    $("#" + delegate).hover(function (event) {
        $("#" + Content).filter(':not(:animated)').fadeIn(200);
    },
    function () {
        $("#" + Content).on("mouseleave",
            function () {
                $("#" + Content).fadeOut('fast');
            });
    });
 
    $(".FunctionTap li").click(function () {
        if (this.hasAttribute("data-Action") === true) {
            var ActionName = $(this).attr("data-Action");
            if (ActionName !== CurrFunctionTap) {
                $(".FunctionTap li").attr("style", "");
                $(this).attr("style", "border-color:green;");
                //$(".FunctionTap li[date-Action='"+ActionName+"']").attr("style","border-color:green;");
                //$('.' + CurrFunctionTap).fadeOut(function() {
                //    $('.' + ActionName).fadeIn(); 
                //});
                $('.' + CurrFunctionTap).animate({opacity:"0",left: '300px' }, function () {
                    if ($('.' + ActionName).attr("style").indexOf("left") > -1) {
                        $('.' + ActionName).animate({ opacity: "1", left: '0px' }).fadeIn();
                    } else {
                        $('.' + ActionName).fadeIn();
                    }
                });
                CurrFunctionTap = ActionName;
            }
        }
    });
}
function OpenChatingDialog() {
    $('body,html').animate({ scrollTop: 0 }, 100);
    CKEDITOR.replace('editor1');
   $(".GhostChatingDiglog").fadeIn(); 
   
} 
function ColseChatingDiglog() {
    $(".GhostChatingDiglog").fadeOut();
}

function SendNewMsg(Ele) {

    var sendDate = getNowFormatDate();
    Msg = CKEDITOR.instances.editor1.getData();
     
    var Html = ' <div class=\"GhostChatingMsgBox\">'+
                  '<div class="GhostChatingMsgBoxSend">'+
    '   <div class="ChatingMsgBoxDate">' + sendDate + '</div>' +
        '  <div class="GhostChatingMsgSend">'+Msg+'</div>' +
        ' </div>' +
        '</div> ';
    console.log(Html);
    $("#" + Ele).children(".GhostChatingDiglogContent").append(Html);
    $("#" + Ele).children(".GhostChatingDiglogContent").scrollTop('999');
    $('body,html').animate({ scrollTop: 0 }, 100); 
    CKEDITOR.instances.editor1.setData('');

}

function getNowFormatDate() {
    var date = new Date();
    var seperator1 = "-";
    var seperator2 = ":";
    var month = date.getMonth() + 1;
    var strDate = date.getDate();
    if (month >= 1 && month <= 9) {
        month = "0" + month;
    }
    if (strDate >= 0 && strDate <= 9) {
        strDate = "0" + strDate;
    }
    var currentdate = date.getFullYear() + seperator1 + month + seperator1 + strDate
            + " " + date.getHours() + seperator2 + date.getMinutes()
            + seperator2 + date.getSeconds();
    return currentdate;
} 