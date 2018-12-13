$(".add-to-cart-action").click(function (e) {

	e.preventDefault();
	$.ajax({
		url: $(this).attr("href"), // comma here instead of semicolon
		success: function () {
			alert("Ürün Sepete Eklendi... "); // or any other indication if you want to show
		}

	});

});