$(document).ready(function() {
	$('#getInTouchLink').on('click', function() {
		$("html, body").animate({ scrollTop: $('footer').offset().top }, 1000);
	});
	
	$('#contactLink').on('click', function() {
		$("html, body").animate({ scrollTop: $('#contactSection').offset().top }, 1000);
	});
	
	$('#aboutLink').on('click', function() {
		$("html, body").animate({ scrollTop: $('#aboutSection').offset().top }, 1000);
	});
	
});
