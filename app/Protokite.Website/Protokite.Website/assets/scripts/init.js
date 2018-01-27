$(document).ready(function() {
	$('#get-in-touch-link').on('click', function() {
		$("html, body").animate({ scrollTop: $('footer').offset().top }, 1000);
	});
	
	$('#contact-link').on('click', function() {
		$("html, body").animate({ scrollTop: $('#contact-section').offset().top }, 1000);
	});
	
	$('#about-link').on('click', function() {
		$("html, body").animate({ scrollTop: $('#about-section').offset().top }, 1000);
	});
	
	setTimeout(function () {
	    $('#email-sent').fadeOut(400);
	}, 3000);
});