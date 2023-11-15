
function DropDownShowHide(event)
{
    var Id = event.currentTarget.id;

    
    var value = document.getElementById("Pages").value;
    var Platformvalue = document.getElementById("PlatformPages").value;
    var Solutionvalue = document.getElementById("SolutionPages").value;
    var Solutioncasevalue = document.getElementById("SolutioncasePages").value;
    var Solutionindustryvalue = document.getElementById("SolutionindustryPages").value;
    var Companyvalue = document.getElementById("CompanyPages").value;
    var Resourcevalue = document.getElementById("ResourcePages").value;
    if (value == 'Homepages')
    {
        $("#PlatformPages").hide();
        $("#SolutionPages").hide();
        $("#CompanyPages").hide();
        $("#ResourcePages").hide();
        $("#SolutioncasePages").hide();
        $("#SolutionindustryPages").hide();
        $("#HomePage").show();
        $("#liveagentPages").hide();
        $("#BroadcastingPages").hide();
        $("#AnalyticsPages").hide();
        $("#AutomatedPages").hide();
        $("#ConversationalPages").hide();
        $("#SegregationPages").hide();
        $("#MarketingPages").hide();
        $("#WhatsAppPages").hide();
        $("#CommercePages").hide();
        $("#SupportPages").hide();
        $("#AuthenticationPages").hide();
        $("#EcommercePages").hide();
        $("#HealthcarePages").hide();
        $("#EdTechPages").hide();
        $("#BankingBFSIPages").hide();
        $("#MediaPages").hide();
        $("#FoodPages").hide();
        $("#TravelPages").hide();
        $("#AboutPages").hide();
        $("#WorkPages").hide();
        $("#PartnerPages").hide();
        $("#BlogPages").hide();
        $("#ContactPages").hide();
        $("#KnowledgePages").hide();
    }
    if (value == 'Platform')
    {
                
        $("#PlatformPages").show();
        $("#SolutionPages").hide();
        $("#CompanyPages").hide();
        $("#ResourcePages").hide();
        $("#SolutioncasePages").hide();
        $("#SolutionindustryPages").hide();
        $("#HomePage").hide();
        $("#WhatsAppPages").hide();
        $("#CommercePages").hide();
        $("#SupportPages").hide();
        $("#AuthenticationPages").hide();
        $("#EcommercePages").hide();
        $("#HealthcarePages").hide();
        $("#EdTechPages").hide();
        $("#BankingBFSIPages").hide();
        $("#MediaPages").hide();
        $("#FoodPages").hide();
        $("#TravelPages").hide();
        $("#AboutPages").hide();
        $("#WorkPages").hide();
        $("#PartnerPages").hide();
        $("#BlogPages").hide();
        $("#ContactPages").hide();
        $("#KnowledgePages").hide();
        if (Platformvalue == "livepages")
        {
            $("#liveagentPages").show();
            $("#BroadcastingPages").hide();
            $("#AnalyticsPages").hide();
            $("#AutomatedPages").hide();
            $("#ConversationalPages").hide();
            $("#SegregationPages").hide();
            $("#MarketingPages").hide();

        }
        if (Platformvalue == "WhatsApp") {
            $("#liveagentPages").hide();
            $("#BroadcastingPages").show();
            $("#AnalyticsPages").hide();
            $("#AutomatedPages").hide();
            $("#ConversationalPages").hide();
            $("#SegregationPages").hide();
            $("#MarketingPages").hide();

        }
        if (Platformvalue == "ReportsAnalytics") {
            $("#liveagentPages").hide();
            $("#BroadcastingPages").hide();
            $("#AnalyticsPages").show();
            $("#AutomatedPages").hide();
            $("#ConversationalPages").hide();
            $("#SegregationPages").hide();
            $("#MarketingPages").hide();

        }
        if (Platformvalue == "AutomatedChatBot") {
            $("#liveagentPages").hide();
            $("#BroadcastingPages").hide();
            $("#AnalyticsPages").hide();
            $("#AutomatedPages").show();
            $("#ConversationalPages").hide();
            $("#SegregationPages").hide();
            $("#MarketingPages").hide();

        }
        if (Platformvalue == "ConversationalMarketing") {
            $("#liveagentPages").hide();
            $("#BroadcastingPages").hide();
            $("#AnalyticsPages").hide();
            $("#AutomatedPages").hide();
            $("#ConversationalPages").show();
            $("#SegregationPages").hide();
            $("#MarketingPages").hide();

        }   
        if (Platformvalue == "AutoSegregation") {
            $("#liveagentPages").hide();
            $("#BroadcastingPages").hide();
            $("#AnalyticsPages").hide();
            $("#AutomatedPages").hide();
            $("#ConversationalPages").hide();
            $("#SegregationPages").show();
            $("#MarketingPages").hide();

        }   
        if (Platformvalue == "AppMarketing") {
            $("#liveagentPages").hide();
            $("#BroadcastingPages").hide();
            $("#AnalyticsPages").hide();
            $("#AutomatedPages").hide();
            $("#ConversationalPages").hide();
            $("#SegregationPages").hide();
            $("#MarketingPages").show();

        }   

    }
    if (value == 'Solution')
    {
        $("#PlatformPages").hide();
        $("#SolutionPages").show();
        $("#CompanyPages").hide();
        $("#ResourcePages").hide();
        $("#HomePage").hide();
        $("#liveagentPages").hide();
        $("#BroadcastingPages").hide();
        $("#AnalyticsPages").hide();
        $("#AutomatedPages").hide();
        $("#ConversationalPages").hide();
        $("#SegregationPages").hide();
        $("#MarketingPages").hide();
        $("#WhatsAppPages").hide();
        $("#CommercePages").hide();
        $("#SupportPages").hide();
        $("#AuthenticationPages").hide();
        $("#EcommercePages").hide();
        $("#HealthcarePages").hide();
        $("#EdTechPages").hide();
        $("#BankingBFSIPages").hide();
        $("#MediaPages").hide();
        $("#FoodPages").hide();
        $("#TravelPages").hide();
        $("#AboutPages").hide();
        $("#WorkPages").hide();
        $("#PartnerPages").hide();
        $("#BlogPages").hide();
        $("#ContactPages").hide();
        $("#KnowledgePages").hide();
        if (Solutionvalue == "Byusecase")
        {
            $("#SolutioncasePages").show();
            $("#SolutionindustryPages").hide();
            if (Solutioncasevalue == "WhatsAppMarketing") {
                $("#WhatsAppPages").show();
                $("#CommercePages").hide();
                $("#SupportPages").hide();
                $("#AuthenticationPages").hide();

            }
            if (Solutioncasevalue == "WhatsappCommerce") {
                $("#WhatsAppPages").hide();
                $("#CommercePages").show();
                $("#SupportPages").hide();
                $("#AuthenticationPages").hide();

            }
            if (Solutioncasevalue == "WhatsappSupport") {
                $("#WhatsAppPages").hide();
                $("#CommercePages").hide();
                $("#SupportPages").show();
                $("#AuthenticationPages").hide();

            }
            if (Solutioncasevalue == "WhatsappAuthentication") {
                $("#WhatsAppPages").hide();
                $("#CommercePages").hide();
                $("#SupportPages").hide();
                $("#AuthenticationPages").show();

            }
        }
        if (Solutionvalue == "ByIndustry")
        {
            $("#SolutioncasePages").hide();
            $("#SolutionindustryPages").show();
            if (Solutionindustryvalue == "EcommerceRetail") {
                $("#EcommercePages").show();
                $("#HealthcarePages").hide();
                $("#EdTechPages").hide();
                $("#BankingBFSIPages").hide();
                $("#MediaPages").hide();
                $("#FoodPages").hide();
                $("#TravelPages").hide();

            }
            if (Solutionindustryvalue == "Healthcare") {
                $("#EcommercePages").hide();
                $("#HealthcarePages").show();
                $("#EdTechPages").hide();
                $("#BankingBFSIPages").hide();
                $("#MediaPages").hide();
                $("#FoodPages").hide();
                $("#TravelPages").hide();

            }
            if (Solutionindustryvalue == "EdTech") {
                $("#EcommercePages").hide();
                $("#HealthcarePages").hide();
                $("#EdTechPages").show();
                $("#BankingBFSIPages").hide();
                $("#MediaPages").hide();
                $("#FoodPages").hide();
                $("#TravelPages").hide();

            }
            if (Solutionindustryvalue == "BankingBFSI") {
                $("#EcommercePages").hide();
                $("#HealthcarePages").hide();
                $("#EdTechPages").hide();
                $("#BankingBFSIPages").show();
                $("#MediaPages").hide();
                $("#FoodPages").hide();
                $("#TravelPages").hide();

            }
            if (Solutionindustryvalue == "Mediaentertainment") {
                $("#EcommercePages").hide();
                $("#HealthcarePages").hide();
                $("#EdTechPages").hide();
                $("#BankingBFSIPages").hide();
                $("#MediaPages").show();
                $("#FoodPages").hide();
                $("#TravelPages").hide();

            }
            if (Solutionindustryvalue == "FoodBeverage") {
                $("#EcommercePages").hide();
                $("#HealthcarePages").hide();
                $("#EdTechPages").hide();
                $("#BankingBFSIPages").hide();
                $("#MediaPages").hide();
                $("#FoodPages").show();
                $("#TravelPages").hide();

            }
            if (Solutionindustryvalue == "TravelHospitality") {
                $("#EcommercePages").hide();
                $("#HealthcarePages").hide();
                $("#EdTechPages").hide();
                $("#BankingBFSIPages").hide();
                $("#MediaPages").hide();
                $("#FoodPages").hide();
                $("#TravelPages").show();
            }   

        }
    }
    if (value == 'Company')
    {
        $("#PlatformPages").hide();
        $("#SolutionPages").hide();
        $("#CompanyPages").show();
        $("#ResourcePages").hide();
        $("#SolutioncasePages").hide();
        $("#SolutionindustryPages").hide();
        $("#HomePage").hide();
        $("#liveagentPages").hide();
        $("#BroadcastingPages").hide();
        $("#AnalyticsPages").hide();
        $("#AutomatedPages").hide();
        $("#ConversationalPages").hide();
        $("#SegregationPages").hide();
        $("#MarketingPages").hide();
        $("#WhatsAppPages").hide();
        $("#CommercePages").hide();
        $("#SupportPages").hide();
        $("#AuthenticationPages").hide();
        $("#EcommercePages").hide();
        $("#HealthcarePages").hide();
        $("#EdTechPages").hide();
        $("#BankingBFSIPages").hide();
        $("#MediaPages").hide();
        $("#FoodPages").hide();
        $("#TravelPages").hide();
        $("#BlogPages").hide();
        $("#ContactPages").hide();
        $("#KnowledgePages").hide();
        if (Companyvalue == "AboutUs") {
            $("#AboutPages").show();
            $("#WorkPages").hide();
            $("#PartnerPages").hide();
        }
        if (Companyvalue == "WorkWithUs") {
            $("#AboutPages").hide();
            $("#WorkPages").show();
            $("#PartnerPages").hide();
        }
        if (Companyvalue == "PartnerWithUs") {
            $("#AboutPages").hide();
            $("#WorkPages").hide();
            $("#PartnerPages").show();
        }
    }
    if (value == 'Resource') {
        $("#PlatformPages").hide();
        $("#SolutionPages").hide();
        $("#CompanyPages").hide();
        $("#ResourcePages").show();
        $("#SolutioncasePages").hide();
        $("#SolutionindustryPages").hide();
        $("#HomePage").hide();
        $("#liveagentPages").hide();
        $("#BroadcastingPages").hide();
        $("#AnalyticsPages").hide();
        $("#AutomatedPages").hide();
        $("#ConversationalPages").hide();
        $("#SegregationPages").hide();
        $("#MarketingPages").hide();
        $("#WhatsAppPages").hide();
        $("#CommercePages").hide();
        $("#SupportPages").hide();
        $("#AuthenticationPages").hide();
        $("#EcommercePages").hide();
        $("#HealthcarePages").hide();
        $("#EdTechPages").hide();
        $("#BankingBFSIPages").hide();
        $("#MediaPages").hide();
        $("#FoodPages").hide();
        $("#TravelPages").hide();
        $("#AboutPages").hide();
        $("#WorkPages").hide();
        $("#PartnerPages").hide();
        if (Resourcevalue == "Blog") {
            $("#BlogPages").show();
            $("#ContactPages").hide();
            $("#KnowledgePages").hide();
        }
        if (Resourcevalue == "ContactUs")
        {
            $("#BlogPages").hide();
            $("#ContactPages").show();
            $("#KnowledgePages").hide();
        }
        if (Resourcevalue == "KnowledgeCenter")
        {
            $("#BlogPages").hide();
            $("#ContactPages").hide();
            $("#KnowledgePages").show();
        }
    }
}

function SendMetaData(event) {

    var currentTargetId = event.currentTarget.id

    switch (currentTargetId) {
        case "Meta_Index":
            var Value = document.getElementById("Meta_Index_input").value;
            var Data = {
                IndexMeta: Value
            };
            var Collumn = "Index"

            break;
        case "Meta_live":
            var Value = document.getElementById("Meta_live_input").value;
            var Data = {
                liveagentsupportMeta: Value
            };
            var Collumn = "live"
            break;
        case "Meta_AppBroad":
            var Value = document.getElementById("Meta_AppBroad_input").value;
            var Data = {
                WhatsAppBroadcastingMeta: Value
            };
            var Collumn = "WhatsAppBroadcasting"
            break;
        case "Meta_Report":
            var Value = document.getElementById("Meta_Report_input").value;
            var Data = {
                ReportsAnalyticsMeta: Value
            };
            var Collumn = "ReportsAnalytics"
            break;
        case "Meta_Auto":
            var Value = document.getElementById("Meta_Auto_input").value;
            var Data = {
                AutomatedChatBotMeta: Value
            };
            var Collumn = "AutomatedChatBot"
            break;
        case "Meta_Conve":
            var Value = document.getElementById("Meta_Conve_input").value;
            var Data = {
                ConversationalMarketingMeta: Value
            };
            var Collumn = "ConversationalMarketing"
            break;
        case "Meta_Segrega":
            var Value = document.getElementById("Meta_Segrega_input").value;
            var Data = {
                AutoSegregationMeta: Value
            };
            var Collumn = "AutoSegregation"
            break;
        case "Meta_Marke":
            var Value = document.getElementById("Meta_Marke_input").value;
            var Data = {
                AppMarketingMeta: Value
            };
            var Collumn = "AppMarketing"
            break;
        case "Meta_AppMark":
            var Value = document.getElementById("Meta_AppMark_input").value;
            var Data = {
                WhatsAppMarketingMeta: Value
            };
            var Collumn = "WhatsAppMarketing"
            break;
        case "Meta_Commer":
            var Value = document.getElementById("Meta_Commer_input").value;
            var Data = {
                WhatsappCommerceMeta: Value
            };
            var Collumn = "WhatsappCommerce"
            break;
        case "Meta_hatsap":
            var Value = document.getElementById("Meta_hatsap_input").value;
            var Data = {
                WhatsappSupportMeta: Value
            };
            var Collumn = "WhatsappSupport"
            break;
        case "Meta_Authen":
            var Value = document.getElementById("Meta_Authen_input").value;
            var Data = {
                WhatsappAuthenticationMeta: Value
            };
            var Collumn = "WhatsappAuthentication"
            break;
        case "Meta_Retail":
            var Value = document.getElementById("Meta_Retail_input").value;
            var Data = {
                EcommerceRetailMeta: Value
            };
            var Collumn = "EcommerceRetail"
            break;
        case "Meta_care":
            var Value = document.getElementById("Meta_care_input").value;
            var Data = {
                HealthcareMeta: Value
            };
            var Collumn = "Healthcare"
            break;
        case "Meta_EdTech":
            var Value = document.getElementById("Meta_EdTech_input").value;
            var Data = {
                EdTechMeta: Value
            };
            var Collumn = "EdTech"
            break;
        case "Meta_BFSI":
            var Value = document.getElementById("Meta_BFSI_input").value;
            var Data = {
                BankingBFSIMeta: Value
            };
            var Collumn = "BankingBFSI"
            break;
        case "Meta_Media":
            var Value = document.getElementById("Meta_Media_input").value;
            var Data = {
                MediaentertainmentMeta: Value
            };
            var Collumn = "Mediaentertainment"
            break;
        case "Meta_Food":
            var Value = document.getElementById("Meta_Food_input").value;
            var Data = {
                FoodBeverageMeta: Value
            };
            var Collumn = "FoodBeverage"
            break;
        case "Meta_Travel":
            var Value = document.getElementById("Meta_Travel_input").value;
            var Data = {
                TravelHospitalityMeta: Value
            };
            var Collumn = "TravelHospitality"
            break;
        case "Meta_AboutUs":
            var Value = document.getElementById("Meta_AboutUs_input").value;
            var Data = {
                AboutUsMeta: Value
            };
            var Collumn = "AboutUs"
            break;
        case "Meta_WithUs":
            var Value = document.getElementById("Meta_WithUs_input").value;
            var Data = {
                WorkWithUsMeta: Value
            };
            var Collumn = "WorkWithUs"
            break;
        case "Meta_Partner":
            var Value = document.getElementById("Meta_Partner_input").value;
            var Data = {
                PartnerWithUsMeta: Value
            };
            var Collumn = "PartnerWithUs"
            break;
        case "Meta_Blog":
            var Value = document.getElementById("Meta_Blog_input").value;
            var Data = {
                BlogMeta: Value
            };
            var Collumn = "Blog"
            break;
        case "Meta_Contact":
            var Value = document.getElementById("Meta_Contact_input").value;
            var Data = {
                ContactUsMeta: Value
            };
            var Collumn = "ContactUs"
            break;
        case "Meta_Center":
            var Value = document.getElementById("Meta_Center_input").value;
            var Data = {
                KnowledgeCenterMeta: Value
            };
            var Collumn = "KnowledgeCenter"
            break;


    }

    $.ajax({
        url: '/SaveAndDelete/SaveMeta',
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

function SendSchemaData(event) {

    var currentTargetId = event.currentTarget.id

    switch (currentTargetId) {
        case "Schema_Index":
            var Value = document.getElementById("Schema_Index_text").value;
            var Data = {
                IndexMeta: Value
            };
            var Collumn = "Index"

            break;
        case "Schema_live":
            var Value = document.getElementById("Schema_live_text").value;
            var Data = {
                liveagentsupportMeta: Value
            };
            var Collumn = "live"
            break;
        case "Schema_AppBroad":
            var Value = document.getElementById("Schema_AppBroad_text").value;
            var Data = {
                WhatsAppBroadcastingMeta: Value
            };
            var Collumn = "WhatsAppBroadcasting"
            break;
        case "Schema_Report":
            var Value = document.getElementById("Schema_Report_text").value;
            var Data = {
                ReportsAnalyticsMeta: Value
            };
            var Collumn = "ReportsAnalytics"
            break;
        case "Schema_Auto":
            var Value = document.getElementById("Schema_Auto_input").value;
            var Data = {
                AutomatedChatBotMeta: Value
            };
            var Collumn = "AutomatedChatBot"
            break;
        case "Schema_Conve":
            var Value = document.getElementById("Schema_Conve_text").value;
            var Data = {
                ConversationalMarketingMeta: Value
            };
            var Collumn = "ConversationalMarketing"
            break;
        case "Schema_Segrega":
            var Value = document.getElementById("Schema_Segrega_text").value;
            var Data = {
                AutoSegregationMeta: Value
            };
            var Collumn = "AutoSegregation"
            break;
        case "Schema_Marke":
            var Value = document.getElementById("Schema_Marke_text").value;
            var Data = {
                AppMarketingMeta: Value
            };
            var Collumn = "AppMarketing"
            break;
        case "Schema_AppMark":
            var Value = document.getElementById("Schema_AppMark_text").value;
            var Data = {
                WhatsAppMarketingMeta: Value
            };
            var Collumn = "WhatsAppMarketing"
            break;
        case "Schema_Commer":
            var Value = document.getElementById("Schema_Commer_text").value;
            var Data = {
                WhatsappCommerceMeta: Value
            };
            var Collumn = "WhatsappCommerce"
            break;
        case "Schema_hatsap":
            var Value = document.getElementById("Schema_hatsap_text").value;
            var Data = {
                WhatsappSupportMeta: Value
            };
            var Collumn = "WhatsappSupport"
            break;
        case "Schema_Authen":
            var Value = document.getElementById("Schema_Authen_text").value;
            var Data = {
                WhatsappAuthenticationMeta: Value
            };
            var Collumn = "WhatsappAuthentication"
            break;
        case "Schema_Retail":
            var Value = document.getElementById("Schema_Retail_text").value;
            var Data = {
                EcommerceRetailMeta: Value
            };
            var Collumn = "EcommerceRetail"
            break;
        case "Schema_care":
            var Value = document.getElementById("Schema_care_text").value;
            var Data = {
                HealthcareMeta: Value
            };
            var Collumn = "Healthcare"
            break;
        case "Schema_EdTech":
            var Value = document.getElementById("Schema_EdTech_text").value;
            var Data = {
                EdTechMeta: Value
            };
            var Collumn = "EdTech"
            break;
        case "Schema_BFSI":
            var Value = document.getElementById("Schema_BFSI_text").value;
            var Data = {
                BankingBFSIMeta: Value
            };
            var Collumn = "BankingBFSI"
            break;
        case "Schema_Media":
            var Value = document.getElementById("Schema_Media_text").value;
            var Data = {
                MediaentertainmentMeta: Value
            };
            var Collumn = "Mediaentertainment"
            break;
        case "Schema_Food":
            var Value = document.getElementById("Schema_Food_text").value;
            var Data = {
                FoodBeverageMeta: Value
            };
            var Collumn = "FoodBeverage"
            break;
        case "Schema_Travel":
            var Value = document.getElementById("Schema_Travel_text").value;
            var Data = {
                TravelHospitalityMeta: Value
            };
            var Collumn = "TravelHospitality"
            break;
        case "Schema_AboutUs":
            var Value = document.getElementById("Schema_AboutUs_text").value;
            var Data = {
                AboutUsMeta: Value
            };
            var Collumn = "AboutUs"
            break;
        case "Schema_WithUs":
            var Value = document.getElementById("Schema_WithUs_text").value;
            var Data = {
                WorkWithUsMeta: Value
            };
            var Collumn = "WorkWithUs"
            break;
        case "Schema_Partner":
            var Value = document.getElementById("Schema_Partner_text").value;
            var Data = {
                PartnerWithUsMeta: Value
            };
            var Collumn = "PartnerWithUs"
            break;
        case "Schema_Blog":
            var Value = document.getElementById("Schema_Blog_text").value;
            var Data = {
                BlogMeta: Value
            };
            var Collumn = "Blog"
            break;
        case "Schema_Contact":
            var Value = document.getElementById("Schema_Contact_text").value;
            var Data = {
                ContactUsMeta: Value
            };
            var Collumn = "ContactUs"
            break;
        case "Schema_Center":
            var Value = document.getElementById("Schema_Center_text").value;
            var Data = {
                KnowledgeCenterMeta: Value
            };
            var Collumn = "KnowledgeCenter"
            break;


    }

    $.ajax({
        url: '/SaveAndDelete/SaveSchema',
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


function checkUncheck(event)
{
    var checkId = event.currentTarget.id;

    switch (checkId) {

        case "Check_Index":
            var Checked = document.getElementById(checkId);
            var Data = {
                IndexMeta: Checked.checked
            };
            var Collumn = "Index"
            break;
        case "Check_live":
            var Checked = document.getElementById(checkId);
            var Data = {
                liveagentsupportMeta: Checked.checked
            };
            var Collumn = "live"
            break;
        case "Check_AppBroad":
            var Checked = document.getElementById(checkId);
            var Data = {
                WhatsAppBroadcastingMeta: Checked.checked
            };
            var Collumn = "WhatsAppBroadcasting"
            break;
        case "Check_Report":
            var Checked = document.getElementById(checkId);
            var Data = {
                ReportsAnalyticsMeta: Checked.checked
            };
            var Collumn = "ReportsAnalytics"
            break;
        case "Check_Auto":
            var Checked = document.getElementById(checkId);
            var Data = {
                AutomatedChatBotMeta: Checked.checked
            };
            var Collumn = "AutomatedChatBot"
            break;
        case "Check_Conve":
            var Checked = document.getElementById(checkId);
            var Data = {
                ConversationalMarketingMeta: Checked.checked
            };
            var Collumn = "ConversationalMarketing"
            break;
        case "Check_Segrega":
            var Checked = document.getElementById(checkId);
            var Data = {
                AutoSegregationMeta: Checked.checked
            };
            var Collumn = "AutoSegregation"
            break;
        case "Check_Marke":
            var Checked = document.getElementById(checkId);
            var Data = {
                AppMarketingMeta: Checked.checked
            };
            var Collumn = "AppMarketing"
            break;
        case "Check_AppMark":
            var Checked = document.getElementById(checkId);
            var Data = {
                WhatsAppMarketingMeta: Checked.checked
            };
            var Collumn = "WhatsAppMarketing"
            break;
        case "Check_Commer":
            var Checked = document.getElementById(checkId);
            var Data = {
                WhatsappCommerceMeta: Checked.checked
            };
            var Collumn = "WhatsappCommerce"
            break;
        case "Check_hatsap":
            var Checked = document.getElementById(checkId);
            var Data = {
                WhatsappSupportMeta: Checked.checked
            };
            var Collumn = "WhatsappSupport"
            break;
        case "Check_Authen":
            var Checked = document.getElementById(checkId);
            var Data = {
                WhatsappAuthenticationMeta: Checked.checked
            };
            var Collumn = "WhatsappAuthentication"
            break;
        case "Check_Retail":
            var Checked = document.getElementById(checkId);
            var Data = {
                EcommerceRetailMeta: Checked.checked
            };
            var Collumn = "EcommerceRetail"
            break;
        case "Check_care":
            var Checked = document.getElementById(checkId);
            var Data = {
                HealthcareMeta: Checked.checked
            };
            var Collumn = "Healthcare"
            break;
        case "Check_EdTech":
            var Checked = document.getElementById(checkId);
            var Data = {
                EdTechMeta: Checked.checked
            };
            var Collumn = "EdTech"
            break;
        case "Check_BFSI":
            var Checked = document.getElementById(checkId);
            var Data = {
                BankingBFSIMeta: Checked.checked
            };
            var Collumn = "BankingBFSI"
            break;
        case "Check_Media":
            var Checked = document.getElementById(checkId);
            var Data = {
                MediaentertainmentMeta: Checked.checked
            };
            var Collumn = "Mediaentertainment"
            break;
        case "Check_Food":
            var Checked = document.getElementById(checkId);
            var Data = {
                FoodBeverageMeta: Checked.checked
            };
            var Collumn = "FoodBeverage"
            break;
        case "Check_Travel":
            var Checked = document.getElementById(checkId);
            var Data = {
                TravelHospitalityMeta: Checked.checked
            };
            var Collumn = "TravelHospitality"
            break;
        case "Check_AboutUs":
            var Checked = document.getElementById(checkId);
            var Data = {
                AboutUsMeta: Checked.checked
            };
            var Collumn = "AboutUs"
            break;
        case "Check_WithUs":
            var Checked = document.getElementById(checkId);
            var Data = {
                WorkWithUsMeta: Checked.checked
            };
            var Collumn = "WorkWithUs"
            break;
        case "Check_Partner":
            var Checked = document.getElementById(checkId);
            var Data = {
                PartnerWithUsMeta: Checked.checked
            };
            var Collumn = "PartnerWithUs"
            break;
        case "Check_Blog":
            var Checked = document.getElementById(checkId);
            var Data = {
                BlogMeta: Checked.checked
            };
            var Collumn = "Blog"
            break;
        case "Check_Contact":
            var Checked = document.getElementById(checkId);
            var Data = {
                ContactUsMeta: Checked.checked
            };
            var Collumn = "ContactUs"
            break;
        case "Check_Center":
            var Checked = document.getElementById(checkId);
            var Data = {
                KnowledgeCenterMeta: Checked.checked
            };
            var Collumn = "KnowledgeCenter"
            break;

    }
    $.ajax({
        url: '/SaveAndDelete/CheckMeta',
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