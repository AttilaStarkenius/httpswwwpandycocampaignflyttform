/*14.3.2022. I begin working with auto_submit.js file and change from: 
window.onload = function () {
    // Onload event of Javascript
    // Initializing timer variable
    var x = 20;
    var y = document.getElementById("timer");
    // Display count down for 20s
    setInterval(function () {
        if (x <= 21 && x >= 1) {
            x--;
            y.innerHTML = '' + x + '';
            if (x == 1) {
                x = 21;
            }
        }
    }, 1000);
    // Form Submitting after 20s
    var auto_refresh = setInterval(function () {
        submitform();
    }, 20000);
    // Form submit function
    function submitform() {
        if (validate()) // Calling validate function
        {
            alert('Form is submitting.....');
            document.getElementById("form").submit();
        }
    }
    // To validate form fields before submission
    function validate() {
        // Storing Field Values in variables
        var name = document.getElementById("name").value;
        var email = document.getElementById("email").value;
        var contact = document.getElementById("contact").value;
        // Regular Expression For Email
        var emailReg = /^([w-.]+@([w-]+.)+[w-]{2,4})?$/;
        // Conditions
        if (name != '' && email != '' && contact != '') {
            if (email.match(emailReg)) {
                if (document.getElementById("male").checked || document.getElementById("female").checked) {
                    if (contact.length == 10) {
                        return true;
                    } else {
                        alert("The Contact No. must be at least 10 digit long!");
                        return false;
                    }
                } else {
                    alert("You must select gender.....!");
                    return false;
                }
            } else {
                alert("Invalid Email Address...!!!");
                return false;
            }
        } else {
            alert("All fields are required.....!");
            return false;
        }
    }
};

to: window.onload = function () {
    // Onload event of Javascript
    // Initializing timer variable
    var x = 3;
    var y = document.getElementById("timer");
    // Display count down for 20s
    setInterval(function () {
        if (x <= 4 && x >= 1) {
            x--;
            y.innerHTML = '' + x + '';
            if (x == 1) {
                x = 4;
            }
        }
    }, 1000);
    // Form Submitting after 20s
    var auto_refresh = setInterval(function () {
        submitform();
    }, 3000);
    // Form submit function
    function submitform() {
        if (validate()) // Calling validate function
        {
            alert('Form is submitting.....');
            document.getElementById("form").submit();
        }
    }
    // To validate form fields before submission
    function validate() {
        // Storing Field Values in variables
        var zipCode = document.getElementById("zipCode").value;
        var squareMeters = document.getElementById("squareMeters").value;
        //var contact = document.getElementById("contact").value;
        // Regular Expression For Email
        //var emailReg = /^([w-.]+@([w-]+.)+[w-]{2,4})?$/;
        //14.3.2022. I use this website as a help: https://www.etl-tools.com/regular-expressions/is-swedish-post-code.html
        //to validate Swedish Post Code like
        //this: var swedishZipCodeReg = /^(s-|S-){0,1}[0-9]{3}\s?[0-9]{2}$/;
        var swedishZipCodeReg = /^(s-|S-){0,1}[0-9]{3}\s?[0-9]{2}$/;
        // Conditions
        if (zipCode != '' && squareMeters != ''/* && contact != ''*//*) {
    if (zipCode.match(swedishZipCodeReg)) {
        return true;
        //if (document.getElementById("male").checked || document.getElementById("female").checked) {
        //    if (contact.length == 10) {
        //        return true;
        //    } else {
        //        alert("The Contact No. must be at least 10 digit long!");
        //        return false;
        //    }
        //} else {
        //    alert("You must select gender.....!");
        //    return false;
        //}
    } else {
        alert("Ingen tjänst tillgänglig i området");
        return false;
    }
} else {
    alert("Du måste fylla i alla fälten");
    return false;
}
    }
};*/

window.onload = function () {
    // Onload event of Javascript
    // Initializing timer variable
    var x = 3;
    var y = document.getElementById("timer");
    // Display count down for 20s
    setInterval(function () {
        if (x <= 4 && x >= 1) {
            x--;
            y.innerHTML = '' + x + '';
            if (x == 1) {
                x = 4;
            }
        }
    }, 1000);
    // Form Submitting after 20s
    var auto_refresh = setInterval(function () {
        submitform();
    }, 3000);
    // Form submit function
    function submitform() {
        if (validate()) // Calling validate function
        {
            alert('Form is submitting.....');
            document.getElementById("form").submit();
        }
    }
    // To validate form fields before submission
    function validate() {
        // Storing Field Values in variables
        var zipCode = document.getElementById("zipCode").value;
        var squareMeters = document.getElementById("squareMeters").value;
        //var contact = document.getElementById("contact").value;
        // Regular Expression For Email
        //var emailReg = /^([w-.]+@([w-]+.)+[w-]{2,4})?$/;
        //14.3.2022. I use this website as a help: https://www.etl-tools.com/regular-expressions/is-swedish-post-code.html
        //to validate Swedish Post Code like
        //this: var swedishZipCodeReg = /^(s-|S-){0,1}[0-9]{3}\s?[0-9]{2}$/;
        var swedishZipCodeReg = /^(s-|S-){0,1}[0-9]{3}\s?[0-9]{2}$/;
        // Conditions
        if (zipCode != '' && squareMeters != ''/* && contact != ''*/) {
            if (zipCode.match(swedishZipCodeReg)) {
                return true;
                //if (document.getElementById("male").checked || document.getElementById("female").checked) {
                //    if (contact.length == 10) {
                //        return true;
                //    } else {
                //        alert("The Contact No. must be at least 10 digit long!");
                //        return false;
                //    }
                //} else {
                //    alert("You must select gender.....!");
                //    return false;
                //}
            } else {
                alert("Ingen tjänst tillgänglig i området");
                return false;
            }
        } else {
            alert("Du måste fylla i alla fälten");
            return false;
        }
    }
};

/*14.3.2022. Now when I view FinalCleaning.cshtml in browser nothing happens even though
 I have filled in values correctly but it looks like this: httpswwwhemfridse
Home
Privacy
Javascript AutoSubmit Form Example
Form will automatically submit in 20 seconds. Name :
16869
 Email :
44
© 2021 - httpswwwhemfridse - Privacy
I commit and push to git with message: "Fixing auto_submit.js 14.3.2022."*/

/*14.3.2022. I continue working with https://attilastarkenius.com/flyttstadning/
by adding separator block, after that paragraph: "Vårt professionella städteam gör ordentligt 
rent in i minsta detalj. När man lämnar bort flyttstädning ska man känna sig trygg – det 
kan du. Din köpare kommer mötas av ett skinande hem och du kan lägga all din energi på ditt nya boende."
and after that list: "Vi tar med all utrustning och städmaterial
Vi städar alla era ytor grundligt
Fönsterputs och karmtvätt ingår"
Then I add to the right "30% of page width" column: "Fönsterputs ingår
Utbildad personal med kollektivavtal
Ansvarsförsäkring"
now the background color for that list is pale pink which is pretty close
to what https://www.hemfrid.se/flyttstadning background color in that
are is but it is not a circle, and I don't find a way to do that on wordpress.
I don't find that function in advanced settings either. So i continue working further;
after that there is only one column and 
it begins with header: "Detta ingår i Hemfrids Flyttstädning"
with H3 styling. After that separator, and after 
separator paragraph: "Informera oss gärna om du har känsliga 
material, t.ex. marmor eller mässing i din bostad. Momenten 
nedan utförs i tömd bostad. Hemfrid erbjuder alltid fem 
arbetsdagars garanti på flyttstädning." After that there should be two columns both 50% wide,
which I create. I work first with left column: I add Bold H3 Style
Header: "Vi utför i alla rum". Now page https://attilastarkenius.com/flyttstadning/
looks like this: Hoppa till innehåll
WEBBPLATSRUBRIK
Hem
Veckostädning
Städning
Flyttstädning
Share Icon
Share Icon
Share Icon
Share Icon
Share Icon
Flyttstädning
Vi på Hemfrid hjälper dig med flyttstädningen! Fönsterputs ingår och vi tar med all utrustning och städmaterial. Självklart med kvalitetsgaranti. Din köpare kommer att mötas av ett skinande hem och du kan ägna tid åt annat.

Vi på Hemfrid erbjuder alltid fem arbetsdagars garanti på vår flyttstädning.

Postnummer(måste anges)
kvm(måste anges)
Fyll i fälten för att se pris
Kontakta oss
Läs mer
V

Så fungerar vår Flyttstädning
Vårt professionella städteam gör ordentligt rent in i minsta detalj. När man lämnar bort flyttstädning ska man känna sig trygg – det kan du. Din köpare kommer mötas av ett skinande hem och du kan lägga all din energi på ditt nya boende.

Vi tar med all utrustning och städmaterial
Vi städar alla era ytor grundligt
Fönsterputs och karmtvätt ingår
Fönsterputs ingår
Utbildad personal med kollektivavtal
Ansvarsförsäkring
Detta ingår i Hemfrids Flyttstädning
Informera oss gärna om du har känsliga material, t.ex. marmor eller mässing i din bostad. Momenten nedan utförs i tömd bostad. Hemfrid erbjuder alltid fem arbetsdagars garanti på flyttstädning.

Vi utför i alla rum
Lägg till mer information om din tjänst. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin id arcu aliquet, elementum nisi quis, condimentum nibh.


Tjänst A
Lägg till mer information om din tjänst. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin id arcu aliquet, elementum nisi quis, condimentum nibh.


Tjänst B
Lägg till mer information om din tjänst. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin id arcu aliquet, elementum nisi quis, condimentum nibh.


Tjänst C
Lägg till mer information om din tjänst. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin id arcu aliquet, elementum nisi quis, condimentum nibh.

Lägg till ett omdöme från någon som gillar din tjänst. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin id arcu aliquet, elementum nisi quis, condimentum nibh. Donec hendrerit dui ut nisi tempor scelerisque.

Jane Doe


Låt oss göra något vackert tillsammans.
Boka möte
Blogg på WordPress.com.

:)

I commit and push to Git Changes 
with message "Adding the final cleaning service describing content to https://attilastarkenius.com/flyttstadning/ 14.3.2022."
*/
