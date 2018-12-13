$(".add-to-cart-action").click(function (e) {

	e.preventDefault();
	$.ajax({
		url: $(this).attr("href"), // comma here instead of semicolon
		success: function () {
           
		}

    }).done(function (partialViewResult) {
        $("#cartSummaryPlaceHolder").html(partialViewResult);
       
    });;

});