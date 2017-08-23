
$(document).ready(function () {
 
});

function InitLoginBlock()
{
    var LoginAcountText = "Please enter your username";
    var LoginPwText = "PassWord";
    var LoginLogo = "<div class=\"LoginLogo\">RunTimeError</div>";
    var LoginAcount = "<div  id = \"LoginAcount\" class=\"LoginInput\"> <input  type=\"text\" id=\"UserName\" value=\"" + LoginAcountText + "\"/></div>";
    var LoginPw = "<div  id  = \"LoginPw\" class=\"LoginInput\"> <input  type=\"text\" id=\"UserPassWord\" value=\"" + LoginPwText + "\"/> </div>";
    var LoginIBut = "<div class=\"LoginIBut\">Login</div>";
    var RegBut = "<div  id =\"RegBut\" class=\"LoginIBut\">Register Acount</div>";

    $('li[id="Login"]').append("<div class=\"LoginBlock\">" + LoginLogo + LoginAcount + LoginPw + LoginIBut + RegBut + "</div>");

    $("#UserName").focus(function () {
        if ($(this).val() == LoginAcountText) {
            $(this).val("");
        }

    });

    $("#UserName").blur(function () {
        if ($(this).val() == "") {
            $(this).val(LoginAcountText);
        }
    });


    $("#UserPassWord").focus(function () {
        $(this).attr({ type: "password" });
        if ($(this).val() == LoginPwText) {
            $(this).val("");
        } else { }

    });

    $("#UserPassWord").blur(function () {
        if ($(this).val() == "") {
            $(this).attr({ type: "text" });
            $(this).val(LoginPwText);
        }
    });
    $("#Login").hover(function (event) {
        //$("div").animate(
        //    {
        //        "filter": "", /* FireFox, Chrome, Opera */
        //        "-webkit-filter": "", /* Chrome, Opera */
        //        "-moz-filter": "",
        //        "-ms-filter": "",
        //        "filter": "",
        //        "filter": "", /* IE6~IE9 */
        //    });
        //$(".LoginBlock").css({"display":"block"});
        // $(".LoginBlock")..fadeIn('slow');

        $(".LoginBlock").filter(':not(:animated)').fadeIn(200);
        // event.stopPropagation();

    }, function () {
        $(".LoginBlock").on("mouseleave", function () {
            //  $(".LoginBlock").css({ "display": "none" });
            $(".LoginBlock").fadeOut('fast');
        });
    }
    );
}