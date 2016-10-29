jQuery(function () {
    jQuery('.rarity').animate({
        bottom: "0px"
    }, 1000, function () {
        jQuery('.ballon-container').animate({
            opacity: "1"
        }, 1000);
    });
});