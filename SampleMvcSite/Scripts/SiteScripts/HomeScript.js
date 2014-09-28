//this is jQuery code, I can explain quickly in person.
//this line basically means, once the page is loaded, do this
$(document).ready(function () {
    HomeScript.init();
});

//this is a namespace in javascript if you're unfamiliar.
var HomeScript = new function() {
    var i = 0;

    //this is a public function, it can be accessed outside of the namespace
    this.init = function () {
        //this changes the button's icon.
        $("#bestButtonEver").button({
            icons: { primary: "ui-icon-heart" }
        });

        $("#bestButtonEver").click(function() {
            if (i % 2 === 0) {
                $("body").css("background: white");
                i++;
            } else {
                $("body").css("background: grey");
                i++;
            }
        });
    }
}