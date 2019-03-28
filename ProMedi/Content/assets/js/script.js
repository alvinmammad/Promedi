(function($){
	"use strict";
	jQuery(document).on('ready', function () {
		// Header Sticky
        $(window).on('scroll', function() {
            if ($(this).scrollTop() >150){  
                $('.header-sticky').addClass("is-sticky");
            }
            else{
                $('.header-sticky').removeClass("is-sticky");
            }
        });

        // Dropdown
        $('.navbar-light .dropdown').on('hover', function () {
            $(this).on('find', '.dropdown-menu').first().stop(true, true).slideDown(100);
        }, function () {
            $(this).on('find', '.dropdown-menu').first().stop(true, true).slideUp(50)
        });

        // Hero slider JS
        $('.hero-slider').owlCarousel({
            items: 1,
            loop:true,
            nav:true,
            autoplay:true,
            autoplayHoverPause: true,
            mouseDrag: false,
            dots: false,
            navText: [
                "<i class='icofont-double-left'></i>",
                "<i class='icofont-double-right'></i>"
            ]
        });
        
        // Popup Video JS
        $('.popup-youtube, .popup-vimeo').magnificPopup({
            disableOn: 300,
            type: 'iframe',
            mainClass: 'mfp-fade',
            removalDelay: 160,
            preloader: false,
            fixedContentPos: false
        });
        
        // Date Picker
        $( function() {
            $( "#datepicker" ).datepicker();
        } );

        // CounterUp JS
        $('.counter').counterUp({
            delay: 15,
            time: 3000
        });

        // Tabs
        (function ($) {
            $('.tab ul.tabs').addClass('active').find('> li:eq(0)').addClass('current');
            $('.tab ul.tabs li a').on('click', function (g) {
                var tab = $(this).closest('.tab'), 
                index = $(this).closest('li').index();
                tab.find('ul.tabs > li').removeClass('current');
                $(this).closest('li').addClass('current');
                tab.find('.tab_content').find('div.tabs_item').not('div.tabs_item:eq(' + index + ')').slideUp();
                tab.find('.tab_content').find('div.tabs_item:eq(' + index + ')').slideDown();
                g.preventDefault();
            });
	    })(jQuery);
 
        // Expert doctors carousel JS
        $('.expert-doctors-carousel').owlCarousel({
            loop:true,
            nav:true,
            autoplay:true,
            autoplayHoverPause: true,
            mouseDrag: false,
            margin: 30,
            dots: false,
            navText: [
                "<i class='icofont-swoosh-left'></i>",
                "<i class='icofont-swoosh-right'></i>"
            ],
            responsive:{
                0:{
                    items:1
                },
                600:{
                    items:2
                },
                1000:{
                    items:3
                }
            }
        });

        // Feedback Carousel JS
        $('.feedback-carousel').owlCarousel({
            loop:true,
            nav:true,
            autoplay:true,
            autoplayHoverPause: true,
            mouseDrag: false,
            margin: 30,
            center: true,
            dots: false,
            navText: [
                "<i class='icofont-swoosh-left'></i>",
                "<i class='icofont-swoosh-right'></i>"
            ],
            responsive:{
                0:{
                    items:1
                },
                768:{
                    items:2
                },
                1200:{
                    items:3
                }
            }
        });
        
        // Latest news Carousel JS
        $('.latest-news-carousel').owlCarousel({
            loop:true,
            nav:true,
            autoplay:true,
            autoplayHoverPause: true,
            mouseDrag: false,
            margin: 30,
            dots: false,
            navText: [
                "<i class='icofont-swoosh-left'></i>",
                "<i class='icofont-swoosh-right'></i>"
            ],
            responsive:{
                0:{
                    items:1
                },
                768:{
                    items:2
                },
                1000:{
                    items:3
                }
            }
        });

        // Subscribe form
		$(".newsletter-form").validator().on("submit", function (event) {
			if (event.isDefaultPrevented()) {
			// handle the invalid form...
				formErrorSub();
				submitMSGSub(false, "Please enter your email correctly.");
			} else {
				// everything looks good!
				event.preventDefault();
			}
		});

		function callbackFunction (resp) {
			if (resp.result === "success") {
				formSuccessSub();
			}
			else {
				formErrorSub();
			}
		}
		function formSuccessSub(){
			$(".newsletter-form")[0].reset();
			submitMSGSub(true, "Thank you for subscribing!");
			setTimeout(function() {
				$("#validator-newsletter").addClass('hide');
			}, 4000)
		}
		function formErrorSub(){
			$(".newsletter-form").addClass("animated shake");
			setTimeout(function() {
				$(".newsletter-form").removeClass("animated shake");
			}, 1000)
		}
		function submitMSGSub(valid, msg){
			if(valid){
				var msgClasses = "validation-success";
			} else {
				var msgClasses = "validation-danger";
			}
			$("#validator-newsletter").removeClass().addClass(msgClasses).text(msg);
		}
		// AJAX MailChimp
		$(".newsletter-form").ajaxChimp({
			url: "https://envytheme.us20.list-manage.com/subscribe/post?u=60e1ffe2e8a68ce1204cd39a5&amp;id=42d6d188d9", // Your url MailChimp
			callback: callbackFunction
		});

        // Back Top Button
        $('body').append('<div id="toTop"><i class="icofont-bubble-up"></i></div>');
        $(window).on('scroll', function () {
            if ($(this).scrollTop() != 0) {
                $('#toTop').fadeIn();
            } else {
                $('#toTop').fadeOut();
            }
        }); 
        $('#toTop').on('click', function(){
            $("html, body").animate({ scrollTop: 0 }, 600);
            return false;
        });
    });
    // preloader
    jQuery(window).on('load', function(){
        jQuery(".preloader").fadeOut(500);
    });
}(jQuery));
 