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