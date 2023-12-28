// Open Sub Menu


function SendData(event) {

    var currentTargetId = event.currentTarget.id

    switch (currentTargetId) {
        case "Tittle_Index":
            var Value = document.getElementById("Index_input").value;
            var Data = {
                Index: Value               
            };
            var Collumn = "Index"
           
            break;
        case "Tittle_live":
            var Value = document.getElementById("live_input").value;
            var Data = {
                liveagentsupport: Value
            };
            var Collumn = "live"
            break;
        case "Tittle_AppBroad":
            var Value = document.getElementById("AppBroad_input").value;
            var Data = {
                WhatsAppBroadcasting: Value
            };
            var Collumn = "WhatsAppBroadcasting"
            break;
        case "Tittle_Report":
            var Value = document.getElementById("Report_input").value;
            var Data = {
                ReportsAnalytics: Value
            };
            var Collumn = "ReportsAnalytics"
            break;
        case "Tittle_Auto":
            var Value = document.getElementById("Auto_input").value;
            var Data = {
                AutomatedChatBot: Value
            };
            var Collumn = "AutomatedChatBot"
            break;
        case "Tittle_Conve":
            var Value = document.getElementById("Conve_input").value;
            var Data = {
                ConversationalMarketing: Value
            };
            var Collumn = "ConversationalMarketing"
            break;
        case "Tittle_Segrega":
            var Value = document.getElementById("Segrega_input").value;
            var Data = {
                AutoSegregation: Value
            };
            var Collumn = "AutoSegregation"
            break;
        case "Tittle_Marke":
            var Value = document.getElementById("Marke_input").value;
            var Data = {
                AppMarketing: Value
            };
            var Collumn = "AppMarketing"
            break;
        case "Tittle_AppMark":
            var Value = document.getElementById("AppMark_input").value;
            var Data = {
                WhatsAppMarketing: Value
            };
            var Collumn = "WhatsAppMarketing"
            break;
        case "Tittle_Commer":
            var Value = document.getElementById("Commer_input").value;
            var Data = {
                WhatsappCommerce: Value
            };
            var Collumn = "WhatsappCommerce"
            break;
        case "Tittle_hatsap":
            var Value = document.getElementById("hatsap_input").value;
            var Data = {
                WhatsappSupport: Value
            };
            var Collumn = "WhatsappSupport"
            break;
        case "Tittle_Authen":
            var Value = document.getElementById("Authen_input").value;
            var Data = {
                WhatsappAuthentication: Value
            };
            var Collumn = "WhatsappAuthentication"
            break;
        case "Tittle_Retail":
            var Value = document.getElementById("Retail_input").value;
            var Data = {
                EcommerceRetail: Value
            };
            var Collumn = "EcommerceRetail"
            break;
        case "Tittle_care":
            var Value = document.getElementById("care_input").value;
            var Data = {
                Healthcare: Value
            };
            var Collumn = "Healthcare"
            break;
        case "Tittle_EdTech":
            var Value = document.getElementById("EdTech_input").value;
            var Data = {
                EdTech: Value
            };
            var Collumn = "EdTech"
            break;
        case "Tittle_BFSI":
            var Value = document.getElementById("BFSI_input").value;
            var Data = {
                BankingBFSI: Value
            };
            var Collumn = "BankingBFSI"
            break;
        case "Tittle_Media":
            var Value = document.getElementById("Media_input").value;
            var Data = {
                Mediaentertainment: Value
            };
            var Collumn = "Mediaentertainment"
            break;
        case "Tittle_Food":
            var Value = document.getElementById("Food_input").value;
            var Data = {
                FoodBeverage: Value
            };
            var Collumn = "FoodBeverage"
            break;
        case "Tittle_Travel":
            var Value = document.getElementById("Travel_input").value;
            var Data = {
                TravelHospitality: Value
            };
            var Collumn = "TravelHospitality"
            break;
        case "Tittle_AboutUs":
            var Value = document.getElementById("AboutUs_input").value;
            var Data = {
                AboutUs: Value
            };
            var Collumn = "AboutUs"
            break;
        case "Tittle_WithUs":
            var Value = document.getElementById("WithUs_input").value;
            var Data = {
                WorkWithUs: Value
            };
            var Collumn = "WorkWithUs"
            break;
        case "Tittle_Partner":
            var Value = document.getElementById("Partner_input").value;
            var Data = {
                PartnerWithUs: Value
            };
            var Collumn = "PartnerWithUs"
            break;
        case "Tittle_Blog":
            var Value = document.getElementById("Blog_input").value;
            var Data = {
                Blog: Value
            };
            var Collumn = "Blog"
            break;
        case "Tittle_Contact":
            var Value = document.getElementById("Contact_input").value;
            var Data = {
                ContactUs: Value
            };
            var Collumn = "ContactUs"
            break;
        case "Tittle_Center":
            var Value = document.getElementById("Center_input").value;
            var Data = {
                KnowledgeCenter: Value
            };
            var Collumn = "KnowledgeCenter"
            break;
        
    }

    $.ajax({
        url: '/SaveAndDelete/Save',
        method: 'POST',
        data: {
            data: Data,
            Column: Collumn
        },   
        success: function (data) {
            alert(data);
            // Handle the server response if needed
        },
        error: function (error) {
            // Handle any errors
        }
    });
}
function DeleteData(event) {

    var currentTargetId = event.currentTarget.id

    switch (currentTargetId) {
        case "Tittle_Index":
            var Data = {
                Index: null
            };
            var Collumn = "Index"
           
            break;
        case "Tittle_live":
            var Value = document.getElementById("live_input").value;
            var Data = {
                liveagentsupport: null
            };
            var Collumn = "live"
            break;
        case "Tittle_AppBroad":
            var Value = document.getElementById("AppBroad_input").value;
            var Data = {
                WhatsAppBroadcasting: null
            };
            var Collumn = "WhatsAppBroadcasting"
            break;
        case "Tittle_Report":
            var Value = document.getElementById("Report_input").value;
            var Data = {
                ReportsAnalytics: null
            };
            var Collumn = "ReportsAnalytics"
            break;
        case "Tittle_Auto":
            var Value = document.getElementById("Auto_input").value;
            var Data = {
                AutomatedChatBot: null
            };
            var Collumn = "AutomatedChatBot"
            break;
        case "Tittle_Conve":
            var Value = document.getElementById("Conve_input").value;
            var Data = {
                ConversationalMarketing: null
            };
            var Collumn = "ConversationalMarketing"
            break;
        case "Tittle_Segrega":
            var Value = document.getElementById("Segrega_input").value;
            var Data = {
                AutoSegregation: null
            };
            var Collumn = "AutoSegregation"
            break;
        case "Tittle_Marke":
            var Value = document.getElementById("Marke_input").value;
            var Data = {
                AppMarketing: null
            };
            var Collumn = "AppMarketing"
            break;
        case "Tittle_AppMark":
            var Value = document.getElementById("AppMark_input").value;
            var Data = {
                WhatsAppMarketing: null
            };
            var Collumn = "WhatsAppMarketing"
            break;
        case "Tittle_Commer":
            var Value = document.getElementById("Commer_input").value;
            var Data = {
                WhatsappCommerce: null
            };
            var Collumn = "WhatsappCommerce"
            break;
        case "Tittle_hatsap":
            var Value = document.getElementById("hatsap_input").value;
            var Data = {
                WhatsappSupport: null
            };
            var Collumn = "WhatsappSupport"
            break;
        case "Tittle_Authen":
            var Value = document.getElementById("Authen_input").value;
            var Data = {
                WhatsappAuthentication: null
            };
            var Collumn = "WhatsappAuthentication"
            break;
        case "Tittle_Retail":
            var Value = document.getElementById("Retail_input").value;
            var Data = {
                EcommerceRetail: null
            };
            var Collumn = "EcommerceRetail"
            break;
        case "Tittle_care":
            var Value = document.getElementById("care_input").value;
            var Data = {
                Healthcare: null
            };
            var Collumn = "Healthcare"
            break;
        case "Tittle_EdTech":
            var Value = document.getElementById("EdTech_input").value;
            var Data = {
                EdTech: null
            };
            var Collumn = "EdTech"
            break;
        case "Tittle_BFSI":
            var Value = document.getElementById("BFSI_input").value;
            var Data = {
                BankingBFSI: null
            };
            var Collumn = "BankingBFSI"
            break;
        case "Tittle_Media":
            var Value = document.getElementById("Media_input").value;
            var Data = {
                Mediaentertainment: null
            };
            var Collumn = "Mediaentertainment"
            break;
        case "Tittle_Food":
            var Value = document.getElementById("Food_input").value;
            var Data = {
                FoodBeverage: null
            };
            var Collumn = "FoodBeverage"
            break;
        case "Tittle_Travel":
            var Value = document.getElementById("Travel_input").value;
            var Data = {
                TravelHospitality: null
            };
            var Collumn = "TravelHospitality"
            break;
        case "Tittle_AboutUs":
            var Value = document.getElementById("AboutUs_input").value;
            var Data = {
                AboutUs: null
            };
            var Collumn = "AboutUs"
            break;
        case "Tittle_WithUs":
            var Value = document.getElementById("WithUs_input").value;
            var Data = {
                WorkWithUs: null
            };
            var Collumn = "WorkWithUs"
            break;
        case "Tittle_Partner":
            var Value = document.getElementById("Partner_input").value;
            var Data = {
                PartnerWithUs: null
            };
            var Collumn = "PartnerWithUs"
            break;
        case "Tittle_Blog":
            var Value = document.getElementById("Blog_input").value;
            var Data = {
                Blog: null
            };
            var Collumn = "Blog"
            break;
        case "Tittle_Contact":
            var Value = document.getElementById("Contact_input").value;
            var Data = {
                ContactUs: null
            };
            var Collumn = "ContactUs"
            break;
        case "Tittle_Center":
            var Value = document.getElementById("Center_input").value;
            var Data = {
                KnowledgeCenter: null
            };
            var Collumn = "KnowledgeCenter"
            break;


    }

    $.ajax({
        url: '/SaveAndDelete/Delete',
        method: 'POST',
        data: {
            data: Data,
            Column: Collumn
        },
        success: function (data) {
            alert(data);
            // Handle the server response if needed
        },
        error: function (error) {
            // Handle any errors
        }
    });
}



$('.drp_btn').click(function(){
  $(this).siblings('.sub_menu').slideToggle();
})
$('.drp_btn').click(function(){
  $(this).siblings('.sub_menu2').slideToggle();
})

// Preloader JS

function preloader_fade() {
  $("#preloader").fadeOut('slow');
}

$(document).ready(function() {
  window.setTimeout("preloader_fade();", 500); //call fade in .5 seconds
}
)
// $(document).ready(function() {
//   !function(w,d){function e(e,n){w.ServiceBell.q=w.ServiceBell.q||[],w.ServiceBell.q.push([e,n])}if(!w.ServiceBell){var i=function(n){for(var i=arguments.length,r=new Array(i>1?i-1:0),c=1;c<i;c++)r[c-1]=arguments[c];e(n,r)};["init","identify","dial","alert","bookMeeting","hide","show","expand","collapse","connect","disconnect"].forEach((function(r){i[r]=function(){for(var i=arguments.length,r=new Array(i),c=0;c<i;c++)r[c]=arguments[c];e(n,r)}})),w.ServiceBell=i}var s=d.createElement("script");s.id="service-bell-script",s.src="https://cdn.servicebell.com/main.js",s.async=1;var r=d.getElementsByTagName("script")[0];r.parentNode.insertBefore(s,r)}(window,document);
//   ServiceBell("init", "3077e4a699ff434b8e9457da0a4f26fe", { mode: "iframe-jit" });
// }
// )
$(document).ready(function() {
  // tawkto-script.js
var Tawk_API=Tawk_API||{}, Tawk_LoadStart=new Date();
(function(){
var s1=document.createElement("script"),s0=document.getElementsByTagName("script")[0];
s1.async=true;
s1.src='https://embed.tawk.to/64c0e2f1cc26a871b02b4f67/1h68nd145';
s1.charset='UTF-8';
s1.setAttribute('crossorigin','*');
s0.parentNode.insertBefore(s1,s0);
})();
}
)

// Add an event listener for the 'beforeunload' event, which is triggered when the user tries to leave the page (e.g., by refreshing).
window.addEventListener('beforeunload', function () {
  // Scroll the page to the top.
  window.scrollTo(0, 0);
});

AOS.init();

// All Slider Js

function OpenModal(event)
{
    var modal = document.getElementById("myModal");
    var closeBtn = document.querySelector(".close");
    var currentTarget = event.currentTarget.id;
    if (currentTarget == "openModalBtn") {
        modal.style.display = "block";
    }

}

function CloseModal(event) {
    var modal = document.getElementById("myModal");
    var currentTarget = event.currentTarget.id;
    if (currentTarget == "CloseModal") {
        modal.style.display = "none";
    }

}




$(document).ready(function () {
    $('#company_slider').owlCarousel({
        loop: true,
        margin: 10,
        nav: false,
        autoplay: true,
        smartSpeed: 1500,
        dots: true,
        responsive: {
            0: {
                items: 2
            },
            600: {
                items: 3
            },
            1000: {
                items: 5
            }
        }
    }) //call fade in .5 seconds
}
)



var FrameSlider = document.getElementById("frmae_slider"); 
if (FrameSlider = ! null) {
    $('#frmae_slider').owlCarousel({
        loop: true,
        margin: 10,
        autoplay: true,
        smartSpeed: 1500,
        nav: false,
        dots: true,
        responsive: {
            0: {
                items: 1
            },
            600: {
                items: 1
            },
            1000: {
                items: 1
            }
        }
    })
}

$('#team_slider').owlCarousel({
    loop:true,
    margin:10,
    nav:false,
    autoplay: true,
    smartSpeed: 1500,
    dots: true, 
    responsive:{
        0:{
            items:1
        },
        600:{
            items:3
        },
        1000:{
            items:3
        }
    }
}) 

$('#client_slider').owlCarousel({
    loop:true,
    margin:10,
    nav:false,
    autoplay: true,
    smartSpeed: 1500,
    dots: true, 
    responsive:{
        0:{
            items:2
        },
        600:{
            items:3
        },
        1000:{
            items:5
        }
    }
})
$('#industry_slider').owlCarousel({
    loop:true,
    margin:10,
    nav:false,
    autoplay:true,
    smartSpeed: 1500,
    autoplay: 3000,
        responsiveClass:true,
    dots: false, 
    responsive:{
        0:{
            items:1
        },
        600:{
            items:3
        },
        1000:{
            items:5
        }
    }
})
$('#product_slider').owlCarousel({
    loop:true,
    margin:10,
    nav:false,
    autoplay:true,
    smartSpeed: 1500,
    autoplay: 3000,
        responsiveClass:true,
    dots: false, 
    responsive:{
        0:{
            items:1
        },
        600:{
            items:3
        },
        1000:{
            items:5
        }
    }
})

$('#usecase_slider').owlCarousel({
    loop:true,
    margin:10,
    nav:false,
    autoplay: true,
    smartSpeed: 1500,
    autoplay: 3000,
    responsiveClass:true,
    dots: false, 
    responsive:{
        0:{
            items:1
        },
        600:{
            items:1
        },
        1000:{
            items:5
        }
    },
})
$('#report_slider').owlCarousel({
    loop:true,
    margin:10,
    nav:false,
    autoplay: true,
    smartSpeed: 1500,
    autoplay: 3000,
        responsiveClass:true,
    dots: false, 
    responsive:{
        0:{
            items:1
        },
        600:{
            items:1
        },
        1000:{
            items:5
        }
    }
    
})
$('#responses_slider').owlCarousel({
    loop:true,
    margin:10,
    nav:false,
    autoplay: true,
    smartSpeed: 1500,
    autoplay: 3000,
        responsiveClass:true,
    dots: false, 
    responsive:{
        0:{
            items:1
        },
        600:{
            items:1
        },
        1000:{
            items:4
        }
    }
})
$('#Auto-Segregation_Slider').owlCarousel({
    loop:true,
    margin:10,
    nav:false,
    autoplay: true,
    smartSpeed: 1500,
    autoplay: 3000,
        responsiveClass:true,
    dots: false, 
    responsive:{
        0:{
            items:1
        },
        600:{
            items:1
        },
        1000:{
            items:5
        }
    }
})


$('#testimonial_slider').owlCarousel({
    loop:true,
    margin:10,
    nav:false,
    autoplay: true,
    smartSpeed: 2500,
    dots: true, 
    responsive:{
        0:{
            items:1
        },
        600:{
            items:1
        },
        1000:{
            items:1
        }
    }
})


$('#screen_slider').owlCarousel({
    loop:true,
    margin:10,
    nav:false,
    dots: true, 
    autoplay: true,
    smartSpeed: 2500,
    center: true,
    responsive:{
        0:{
            items:1
        },
        600:{
            items:3
        },
        1000:{
            items:5
        }
    }
})

// image accordion change

    $(document).ready(function () {
        // Add click event listeners to accordion buttons
        $(".accordion-button").hover(function () {
          // Get the index of the clicked accordion
          var accordionIndex = $(this).parents(".accordion-item").index();

          // Change the image based on the accordion index
          changeImage(accordionIndex);
      });

        function changeImage(index) {
            var imageContainer2 = $("#imageContainer2");
            var image1 = $("#image1");
            var image2 = $("#image2");
            var image3 = $("#image3");

            switch (index) {
                case 0:
                    imageContainer2.attr("src", "image/whatsapp-marketing.webp");
                    break;
                case 1:
                    imageContainer2.attr("src", "image/whatsapp-commerce.webp");
                    break;
                case 2:
                    imageContainer2.attr("src", "image/whatsapp-support.webp");
                    break;
             
                case 3:
                    imageContainer2.attr("src", "image/whatsapp-authertication.webp");
                    break;
                default:
                    imageContainer2.attr("src", "image/whatsapp-marketing.webp");
                    break;
            }
        }
    });
    $(document).ready(function () {
        // Add click event listeners to accordion buttons
        $(".accordion-button").on("click", function () {
            // Get the index of the clicked accordion
            var accordionIndex = $(this).parents(".accordion-item").index();

            // Change the image based on the accordion index
            changeImage(accordionIndex);
        });

        function changeImage(index) {
            var imageContainer = $("#imageContainer");
            var image1 = $("#image1");
            var image2 = $("#image2");
            var image3 = $("#image3");
            var image4 = $("#image4");
            var image5 = $("#image5");

            switch (index) {
                case 0:
                    imageContainer.attr("src", "image/automated-chatbot.webp");
                    break;
                case 1:
                    imageContainer.attr("src", "image/whatsapp-broadcasting.webp");
                    break;
                case 2:
                    imageContainer.attr("src", "image/App-Marketplace.webp");
                    break;
             
                case 3:
                    imageContainer.attr("src", "image/Spark-Engagement-Drive-Targeted-Ad-Campaigns-Real-Time-Updates-for-Maximum-Impact!.webp");
                    break;
                case 4:
                    imageContainer.attr("src", "image/assign-agents-to-create-firm-customer-relationships.webp");
                    break;
                case 5:
                    imageContainer.attr("src", "image/Share-Product-Catalogs-at-Scale.webp");
                    break;
                default:
                    imageContainer.attr("src", "image/automated-chatbot.webp");
                    break;
            }
        }
    });

    // image accordion change


// Number Count
window.addEventListener('scroll', function() {
	var element = document.querySelector('#counter');
	var position = element.getBoundingClientRect();

	// checking whether fully visible
	if(position.top >= 0 && position.bottom <= window.innerHeight) {
    $('.counter-value').each(function() {
      var $this = $(this),
        countTo = $this.attr('data-count');
      $({
        countNum: $this.text()
      }).animate({
          countNum: countTo
        },

        {

          duration: 2000,
          easing: 'swing',
          step: function() {
            $this.text(Math.floor(this.countNum));
          },
          complete: function() {
            $this.text(this.countNum);
            //alert('finished');
          }

        });
    });
	}

	if(position.top < window.innerHeight && position.bottom >= 0) {
		//console.log('Element is partially visible in screen');
	}else{
    //console.log('Element is not visible');
    $('.counter-value').each(function() {
      var $this = $(this),
        countTo = 0;
      $({
        countNum: $this.text()
      }).animate({
          countNum: countTo
        },

        {

          duration: 100,
          easing: 'swing',
          step: function() {
            $this.text(Math.floor(this.countNum));
          },
          complete: function() {
            $this.text(this.countNum);
            //alert('finished');
          }

        });
    });   
  }
});



// --------Magnify-popup

$(function() {
    $('.popup-youtube').magnificPopup({
        disableOn: 700,
        type: 'iframe',
        mainClass: 'mfp-fade',
        removalDelay: 160,
        preloader: false,
        fixedContentPos: false
    });
});


// Pricing Section Year Month Jquery
$(document).ready(function () {

    $(".tog_block").click(function () {
      $(".tog_btn").toggleClass('month_active');
      $('.month').toggleClass('active');
      $('.years').toggleClass('active');

      $('.monthly_plan').toggleClass('active');
      $('.yearly_plan').toggleClass('active');

    })

  });

  $(document).ready(function () {
    // Add minus icon for collapse element which is open by default
    $(".collapse.show").each(function () {
      $(this)
        .prev(".card-header")
        .find(".icon_faq")
        .addClass("icofont-minus")
        .removeClass("icofont-plus");
    });


    // Toggle plus minus icon on show hide of collapse element
    $(".collapse").on("show.bs.collapse", function () {
        $(this).prev(".card-header").find(".icon_faq").removeClass("icofont-plus").addClass("icofont-minus");
      })
      .on("hide.bs.collapse", function () {
        $(this).prev(".card-header").find(".icon_faq").removeClass("icofont-minus").addClass("icofont-plus");
      });

      $(".collapse").on("show.bs.collapse", function () {
        $(this).prev(".card-header").children('h2').children('.btn').addClass("active");
      })
      .on("hide.bs.collapse", function () {
        $(this).prev(".card-header").children('h2').children('.btn').removeClass("active");
      });
  });


// Download Section Hover Jquery
window.addEventListener('scroll', function() {
	var element = document.querySelector('.free_text');
	var position = element.getBoundingClientRect();

	if(position.top < window.innerHeight && position.bottom >= 0) {
    $('.purple_backdrop').css("opacity", "1");
	}else{
    //console.log('Element is not visible');
    $('.purple_backdrop').css("opacity", "0");
  }
});

$(window).on('resize', function() {
  if ($(window).width()<768) {
      
    window.addEventListener('scroll', function() {
      var element = document.querySelector('.mobile_mockup');
      var position = element.getBoundingClientRect();
    
      if(position.top < window.innerHeight && position.bottom >= 0) {
        $('.purple_backdrop').css("opacity", "1");
      }else{
        //console.log('Element is not visible');
        $('.purple_backdrop').css("opacity", "0");
      }
    });

  }  
  else {

    window.addEventListener('scroll', function() {
      var element = document.querySelector('.free_text');
      var position = element.getBoundingClientRect();
    
      if(position.top < window.innerHeight && position.bottom >= 0) {
        $('.purple_backdrop').css("opacity", "1");
      }else{
        //console.log('Element is not visible');
        $('.purple_backdrop').css("opacity", "0");
      }
    });

  }
});


// Scrool-top
$(document).ready(function() {
  var toTop = $('.go_top');
  toTop.on('click', function() {
    $('html, body').animate({scrollTop: $('html, body').offset().top,}, 400);
  });

  $(window).scroll(function() {
    // declare variable
    var topPos = $(this).scrollTop();

    // if user scrolls down - show scroll to top button
    if (topPos > 750) {
      $(toTop).css("opacity", "1");

    } else {
      $(toTop).css("opacity", "0");
    }

  });

});

// Fix Header Js
$(window).scroll(function(){
  if ($(window).scrollTop() >= 250) {
      $('header').addClass('fix_style');
  }
  else {
      $('header').removeClass('fix_style');
  }
  if ($(window).scrollTop() >= 260) {
      $('header').addClass('fixed');
  }
  else {
      $('header').removeClass('fixed');
  }
});




//YOUTUBE VIDEO
$('.play-button').click(function(e){
  var iframeEl = $('<iframe>', { src: $(this).data('url') });
  $('#youtubevideo').attr('src', $(this).data('url'));
})

$('#close-video').click(function(e){
  $('#youtubevideo').attr('src', '');
}); 

$(document).on('hidden.bs.modal','#myModal', function () {
  $('#youtubevideo').attr('src', '');
}); 

$(document).ready(function() {
  // Handle click event on accordion headers
  $('.accordion-header').click(function() {
    // Toggle the associated content
    $(this).next('.accordion-content').slideToggle();

    // Close other accordion panels
    $('.accordion-content').not($(this).next('.accordion-content')).slideUp();
  });
});

// Close btn on click 

$(document).ready(function(){
  $('.navbar-toggler').click(function(){
    if($(this).children('span').children('.ico_menu').hasClass('icofont-navigation-menu')) {
      $(this).children('span').children('.ico_menu').removeClass('icofont-navigation-menu').addClass('icofont-close');
    } else {
      $(this).children('span').children('.ico_menu').removeClass('icofont-close').addClass('icofont-navigation-menu');
    }
  });
});

(function() {
  $('.toggle-wrap').on('click', function() {
    $(this).toggleClass('active');
    $('aside').animate({width: 'toggle'}, 200);
  });
})();

// hover
jQuery(document).ready(function($) {
  $('.custom-accordion-tab').on('click', function() {
      var $tabContent = $(this).siblings('.elementor-tab-content');
      var $image = $tabContent.find('.your-image-class');

      // Change the image source here
      $image.attr('src', 'path/to/your/new-image.jpg');
  });
});

function proceed() {
  
  window.location.href = 'https://'+LoginPage_TeamId.value+'.anantya.ai';
}


// scroll text image change
$(window).scroll (function(){
  let o=$(window),i=$("background"), t=$(".section"), s=o.scrollTop()+o.height()/3;
  t.each(function(){
     $(this).position().top<=s&&$(this).position().top+$(this).height()>s&&(i. removeClass(function(o,i){
         return i.match(/(^|\s) color-\s+/g)||[].join(" ")}
         ),$(".section").removeClass("active"), $(this).addClass("active"))})}


 ).scroll();

// horizontal timeline
jQuery(document).ready(function($){
	var timelines = $('.cd-horizontal-timeline'),
		eventsMinDistance = 60;

	(timelines.length > 0) && initTimeline(timelines);

	function initTimeline(timelines) {
		timelines.each(function(){
			var timeline = $(this),
				timelineComponents = {};
			//cache timeline components 
			timelineComponents['timelineWrapper'] = timeline.find('.events-wrapper');
			timelineComponents['eventsWrapper'] = timelineComponents['timelineWrapper'].children('.events');
			timelineComponents['fillingLine'] = timelineComponents['eventsWrapper'].children('.filling-line');
			timelineComponents['timelineEvents'] = timelineComponents['eventsWrapper'].find('a');
			timelineComponents['timelineDates'] = parseDate(timelineComponents['timelineEvents']);
			timelineComponents['eventsMinLapse'] = minLapse(timelineComponents['timelineDates']);
			timelineComponents['timelineNavigation'] = timeline.find('.cd-timeline-navigation');
			timelineComponents['eventsContent'] = timeline.children('.events-content');

			//assign a left postion to the single events along the timeline
			setDatePosition(timelineComponents, eventsMinDistance);
			//assign a width to the timeline
			var timelineTotWidth = setTimelineWidth(timelineComponents, eventsMinDistance);
			//the timeline has been initialize - show it
			timeline.addClass('loaded');

			//detect click on the next arrow
			timelineComponents['timelineNavigation'].on('click', '.next', function(event){
				event.preventDefault();
				updateSlide(timelineComponents, timelineTotWidth, 'next');
			});
			//detect click on the prev arrow
			timelineComponents['timelineNavigation'].on('click', '.prev', function(event){
				event.preventDefault();
				updateSlide(timelineComponents, timelineTotWidth, 'prev');
			});
			//detect click on the a single event - show new event content
			timelineComponents['eventsWrapper'].on('click', 'a', function(event){
				event.preventDefault();
				timelineComponents['timelineEvents'].removeClass('selected');
				$(this).addClass('selected');
				updateOlderEvents($(this));
				updateFilling($(this), timelineComponents['fillingLine'], timelineTotWidth);
				updateVisibleContent($(this), timelineComponents['eventsContent']);
			});

			//on swipe, show next/prev event content
			timelineComponents['eventsContent'].on('swipeleft', function(){
				var mq = checkMQ();
				( mq == 'mobile' ) && showNewContent(timelineComponents, timelineTotWidth, 'next');
			});
			timelineComponents['eventsContent'].on('swiperight', function(){
				var mq = checkMQ();
				( mq == 'mobile' ) && showNewContent(timelineComponents, timelineTotWidth, 'prev');
			});

			//keyboard navigation
			$(document).keyup(function(event){
				if(event.which=='37' && elementInViewport(timeline.get(0)) ) {
					showNewContent(timelineComponents, timelineTotWidth, 'prev');
				} else if( event.which=='39' && elementInViewport(timeline.get(0))) {
					showNewContent(timelineComponents, timelineTotWidth, 'next');
				}
			});
		});
	}

	function updateSlide(timelineComponents, timelineTotWidth, string) {
		//retrieve translateX value of timelineComponents['eventsWrapper']
		var translateValue = getTranslateValue(timelineComponents['eventsWrapper']),
			wrapperWidth = Number(timelineComponents['timelineWrapper'].css('width').replace('px', ''));
		//translate the timeline to the left('next')/right('prev') 
		(string == 'next') 
			? translateTimeline(timelineComponents, translateValue - wrapperWidth + eventsMinDistance, wrapperWidth - timelineTotWidth)
			: translateTimeline(timelineComponents, translateValue + wrapperWidth - eventsMinDistance);
	}

	function showNewContent(timelineComponents, timelineTotWidth, string) {
		//go from one event to the next/previous one
		var visibleContent =  timelineComponents['eventsContent'].find('.selected'),
			newContent = ( string == 'next' ) ? visibleContent.next() : visibleContent.prev();

		if ( newContent.length > 0 ) { //if there's a next/prev event - show it
			var selectedDate = timelineComponents['eventsWrapper'].find('.selected'),
				newEvent = ( string == 'next' ) ? selectedDate.parent('li').next('li').children('a') : selectedDate.parent('li').prev('li').children('a');
			
			updateFilling(newEvent, timelineComponents['fillingLine'], timelineTotWidth);
			updateVisibleContent(newEvent, timelineComponents['eventsContent']);
			newEvent.addClass('selected');
			selectedDate.removeClass('selected');
			updateOlderEvents(newEvent);
			updateTimelinePosition(string, newEvent, timelineComponents, timelineTotWidth);
		}
	}

	function updateTimelinePosition(string, event, timelineComponents, timelineTotWidth) {
		//translate timeline to the left/right according to the position of the selected event
		var eventStyle = window.getComputedStyle(event.get(0), null),
			eventLeft = Number(eventStyle.getPropertyValue("left").replace('px', '')),
			timelineWidth = Number(timelineComponents['timelineWrapper'].css('width').replace('px', '')),
			timelineTotWidth = Number(timelineComponents['eventsWrapper'].css('width').replace('px', ''));
		var timelineTranslate = getTranslateValue(timelineComponents['eventsWrapper']);

        if( (string == 'next' && eventLeft > timelineWidth - timelineTranslate) || (string == 'prev' && eventLeft < - timelineTranslate) ) {
        	translateTimeline(timelineComponents, - eventLeft + timelineWidth/2, timelineWidth - timelineTotWidth);
        }
	}

	function translateTimeline(timelineComponents, value, totWidth) {
		var eventsWrapper = timelineComponents['eventsWrapper'].get(0);
		value = (value > 0) ? 0 : value; //only negative translate value
		value = ( !(typeof totWidth === 'undefined') &&  value < totWidth ) ? totWidth : value; //do not translate more than timeline width
		setTransformValue(eventsWrapper, 'translateX', value+'px');
		//update navigation arrows visibility
		(value == 0 ) ? timelineComponents['timelineNavigation'].find('.prev').addClass('inactive') : timelineComponents['timelineNavigation'].find('.prev').removeClass('inactive');
		(value == totWidth ) ? timelineComponents['timelineNavigation'].find('.next').addClass('inactive') : timelineComponents['timelineNavigation'].find('.next').removeClass('inactive');
	}

	function updateFilling(selectedEvent, filling, totWidth) {
		//change .filling-line length according to the selected event
		var eventStyle = window.getComputedStyle(selectedEvent.get(0), null),
			eventLeft = eventStyle.getPropertyValue("left"),
			eventWidth = eventStyle.getPropertyValue("width");
		eventLeft = Number(eventLeft.replace('px', '')) + Number(eventWidth.replace('px', ''))/2;
		var scaleValue = eventLeft/totWidth;
		setTransformValue(filling.get(0), 'scaleX', scaleValue);
	}

	function setDatePosition(timelineComponents, min) {
		for (i = 0; i < timelineComponents['timelineDates'].length; i++) { 
		    var distance = daydiff(timelineComponents['timelineDates'][0], timelineComponents['timelineDates'][i]),
		    	distanceNorm = Math.round(distance/timelineComponents['eventsMinLapse']) + 2;
		    timelineComponents['timelineEvents'].eq(i).css('left', distanceNorm*min+'px');
		}
	}

	function setTimelineWidth(timelineComponents, width) {
		var timeSpan = daydiff(timelineComponents['timelineDates'][0], timelineComponents['timelineDates'][timelineComponents['timelineDates'].length-1]),
			timeSpanNorm = timeSpan/timelineComponents['eventsMinLapse'],
			timeSpanNorm = Math.round(timeSpanNorm) + 4,
			totalWidth = timeSpanNorm*width;
		timelineComponents['eventsWrapper'].css('width', totalWidth+'px');
		updateFilling(timelineComponents['timelineEvents'].eq(0), timelineComponents['fillingLine'], totalWidth);
	
		return totalWidth;
	}

	function updateVisibleContent(event, eventsContent) {
		var eventDate = event.data('date'),
			visibleContent = eventsContent.find('.selected'),
			selectedContent = eventsContent.find('[data-date="'+ eventDate +'"]'),
			selectedContentHeight = selectedContent.height();

		if (selectedContent.index() > visibleContent.index()) {
			var classEnetering = 'selected enter-right',
				classLeaving = 'leave-left';
		} else {
			var classEnetering = 'selected enter-left',
				classLeaving = 'leave-right';
		}

		selectedContent.attr('class', classEnetering);
		visibleContent.attr('class', classLeaving).one('webkitAnimationEnd oanimationend msAnimationEnd animationend', function(){
			visibleContent.removeClass('leave-right leave-left');
			selectedContent.removeClass('enter-left enter-right');
		});
		eventsContent.css('height', selectedContentHeight+'px');
	}

	function updateOlderEvents(event) {
		event.parent('li').prevAll('li').children('a').addClass('older-event').end().end().nextAll('li').children('a').removeClass('older-event');
	}

	function getTranslateValue(timeline) {
		var timelineStyle = window.getComputedStyle(timeline.get(0), null),
			timelineTranslate = timelineStyle.getPropertyValue("-webkit-transform") ||
         		timelineStyle.getPropertyValue("-moz-transform") ||
         		timelineStyle.getPropertyValue("-ms-transform") ||
         		timelineStyle.getPropertyValue("-o-transform") ||
         		timelineStyle.getPropertyValue("transform");

        if( timelineTranslate.indexOf('(') >=0 ) {
        	var timelineTranslate = timelineTranslate.split('(')[1];
    		timelineTranslate = timelineTranslate.split(')')[0];
    		timelineTranslate = timelineTranslate.split(',');
    		var translateValue = timelineTranslate[4];
        } else {
        	var translateValue = 0;
        }

        return Number(translateValue);
	}

	function setTransformValue(element, property, value) {
		element.style["-webkit-transform"] = property+"("+value+")";
		element.style["-moz-transform"] = property+"("+value+")";
		element.style["-ms-transform"] = property+"("+value+")";
		element.style["-o-transform"] = property+"("+value+")";
		element.style["transform"] = property+"("+value+")";
	}

	//based on http://stackoverflow.com/questions/542938/how-do-i-get-the-number-of-days-between-two-dates-in-javascript
	function parseDate(events) {
		var dateArrays = [];
		events.each(function(){
			var dateComp = $(this).data('date').split('/'),
				newDate = new Date(dateComp[2], dateComp[1]-1, dateComp[0]);
			dateArrays.push(newDate);
		});
	    return dateArrays;
	}

	function parseDate2(events) {
		var dateArrays = [];
		events.each(function(){
			var singleDate = $(this),
				dateComp = singleDate.data('date').split('T');
			if( dateComp.length > 1 ) { //both DD/MM/YEAR and time are provided
				var dayComp = dateComp[0].split('/'),
					timeComp = dateComp[1].split(':');
			} else if( dateComp[0].indexOf(':') >=0 ) { //only time is provide
				var dayComp = ["2000", "0", "0"],
					timeComp = dateComp[0].split(':');
			} else { //only DD/MM/YEAR
				var dayComp = dateComp[0].split('/'),
					timeComp = ["0", "0"];
			}
			var	newDate = new Date(dayComp[2], dayComp[1]-1, dayComp[0], timeComp[0], timeComp[1]);
			dateArrays.push(newDate);
		});
	    return dateArrays;
	}

	function daydiff(first, second) {
	    return Math.round((second-first));
	}

	function minLapse(dates) {
		//determine the minimum distance among events
		var dateDistances = [];
		for (i = 1; i < dates.length; i++) { 
		    var distance = daydiff(dates[i-1], dates[i]);
		    dateDistances.push(distance);
		}
		return Math.min.apply(null, dateDistances);
	}

	/*
		How to tell if a DOM element is visible in the current viewport?
		http://stackoverflow.com/questions/123999/how-to-tell-if-a-dom-element-is-visible-in-the-current-viewport
	*/
	function elementInViewport(el) {
		var top = el.offsetTop;
		var left = el.offsetLeft;
		var width = el.offsetWidth;
		var height = el.offsetHeight;

		while(el.offsetParent) {
		    el = el.offsetParent;
		    top += el.offsetTop;
		    left += el.offsetLeft;
		}

		return (
		    top < (window.pageYOffset + window.innerHeight) &&
		    left < (window.pageXOffset + window.innerWidth) &&
		    (top + height) > window.pageYOffset &&
		    (left + width) > window.pageXOffset
		);
	}

	function checkMQ() {
		//check if mobile or desktop device
		return window.getComputedStyle(document.querySelector('.cd-horizontal-timeline'), '::before').getPropertyValue('content').replace(/'/g, "").replace(/"/g, "");
	}
});




// vertical navtab
jQuery('.tab-title').click(function(event) {
  event.preventDefault();
  jQuery(this).addClass('active');
  jQuery(this).siblings().removeClass('active');

  var ph = jQuery(this).parent().height();
  var ch = jQuery(this).next().height();

  if (ch > ph) {
    jQuery(this).parent().css({
      'min-height': ch + 'px'
    });
  } else {
    jQuery(this).parent().css({
      'height': 'auto'
    });
  }
});

function tabParentHeight() {
  var ph = jQuery('.section-tab').height();
  var ch = jQuery('.tab-content').height();
  if (ch > ph) {
    jQuery('.section-tab').css({
      'height': ch + 'px'
    });
  } else {
    jQuery(this).parent().css({
      'height': 'auto'
    });
  }
}

jQuery(window).resize(function() {
  tabParentHeight();
});

jQuery(document).resize(function() {
  tabParentHeight();
});
tabParentHeight();

// NAVTAB2
window.dataLayer = window.dataLayer || [];window.dataLayer.push({"platform":"gatsby"});
 


// navtab3

$(window).scroll (function(){
  let o=$(window),i=$("body"), t=$(".section"), s=o.scrollTop()+o.height()/3;
  t.each(function(){
     $(this).position().top<=s&&$(this).position().top+$(this).height()>s&&(i. removeClass(function(o,i){
         return i.match(/(^|\s) color-\s+/g)||[].join(" ")}
         ),$(".section").removeClass("active"), $(this).addClass("active"))})}


 ).scroll();
 
  // industry iste section content change on hover


//  $(document).ready(function () {
//   const tabs = $('.travel .btn-secondary');
//   const tabContent = $('.travel .tab-pane');

//   // Function to switch tab content on hover
//   function switchTabContentOnHover(event) {
//       const hoveredTab = $(event.target).data('bs-target');
//       tabContent.removeClass('active');
//       $(hoveredTab).addClass('active');
//   }

//   // Bind the mouseover event to the switchTabContentOnHover function for each tab
//   tabs.on('mouseover', switchTabContentOnHover);
// });
 
//   // industry iste section content change on hover


//  $(document).ready(function () {
//   const tabs = $('.anantya .btn-secondary');
//   const tabContent = $('.anantya .tab-pane');

//   // Function to switch tab content on hover
//   function switchTabContentOnHover(event) {
//       const hoveredTab = $(event.target).data('bs-target');
//       tabContent.removeClass('active');
//       $(hoveredTab).addClass('active');
//   }

//   // Bind the mouseover event to the switchTabContentOnHover function for each tab
//   tabs.on('mouseover', switchTabContentOnHover);
// });


// chatflow

$(document).ready(function () {
  // Show the chat-text on hover of the whatsapp-btn
  $('.whatsapp-btn').hover(function () {
      $('.chat-text').fadeIn(200);
  }, function () {
      $('.chat-text').fadeOut(200);
  });


});

// Function to generate QR code


function openModal() {
    const modal = document.getElementById("myModal");
    modal.style.display = "block";
    
    generateLinkAndQRCode();
}

function closeModal() {
    const modal = document.getElementById("myModal");
    modal.style.display = "none";
}

function generateLinkAndQRCode() {
    const phoneNumber = document.getElementById('phone-number').value;
    const email = document.getElementById('email').value;
    const customMessage = encodeURIComponent(document.getElementById('custom-message').value);

    // Generate WhatsApp link with custom message
    const whatsappLink = `https://wa.me/${phoneNumber}?text=${customMessage}`;
    const whatsappLinkElement = document.getElementById('whatsapp-link');
    whatsappLinkElement.href = whatsappLink;
    whatsappLinkElement.innerText = whatsappLink;

    // Generate QR Code
    const qrData = `Phone: ${phoneNumber}\nEmail: ${email}\nCustom Message: ${customMessage}`;
    const qrcodeElement = document.getElementById('qrcode');
    const qrcode = new QRCode(qrcodeElement, {
        text: qrData,
        width: 128,
        height: 128
    });
}

function copyToClipboard() {
    const whatsappLink = document.getElementById('whatsapp-link').innerText;
    const tempInput = document.createElement("input");
    tempInput.value = whatsappLink;
    document.body.appendChild(tempInput);
    tempInput.select();
    document.execCommand("copy");
    document.body.removeChild(tempInput);

    const copyMessage = document.getElementById('copy-message');
    copyMessage.style.display = 'block';
    copyMessage.innerText = 'Link has been copied to clipboard!';
}

function downloadQRCode() {
    const qrcodeCanvas = document.querySelector('#qrcode canvas');
    const link = document.createElement('a');
    link.download = 'qrcode.png';
    qrcodeCanvas.toBlob(function(blob) {
        link.href = URL.createObjectURL(blob);
        link.click();
    });
}

function goBack() {
    const copyMessage = document.getElementById('copy-message');
    copyMessage.style.display = 'none';

    closeModal();
}


window.addEventListener('scroll', function() {
  if (window.innerWidth >= 768) { // Adjust the breakpoint (992px) as needed for your design
      var scroll = window.scrollY;
      if (scroll > 140 && scroll < 1980) {
          document.getElementById('slices').style.position = 'fixed';
          document.getElementById('slices').style.marginTop = '-190px';
      } else
      {
          document.getElementById('slices').style.position = 'relative';
          document.getElementById('slices').style.marginTop = 'auto';
      }
  }
});

function Recat(){
  const headerTop = document.getElementById('header-top11');
  headerTop.style.display = 'none';
}
window.addEventListener('scroll', function() {
  if (window.innerWidth >= 768) { // Adjust the breakpoint (992px) as needed for your design
      var scroll = window.scrollY;
      if (scroll > 140 && scroll < 1980) {
          document.getElementById('slices').style.position = 'fixed';
          document.getElementById('slices').style.marginTop = '-190px';
      } else {
          document.getElementById('slices').style.position = 'relative';
          document.getElementById('slices').style.marginTop = 'auto';
      }
  }
});



