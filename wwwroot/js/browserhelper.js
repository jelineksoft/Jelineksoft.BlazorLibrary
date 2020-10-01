window.getDimensions = function() {
    return {
        width: window.innerWidth,
        height: window.innerHeight
    };
};

window.focusElementByRef = function (element) {
            element.focus();
        };

window.focusElementById = function (id) {
    const element = document.getElementById(id);
    element.focus();
}

function focusInputFromBlazor(selector) {
    var input = document.querySelector(selector);
    if (!focusInput(input)) {
        input = input.querySelector("input");
        focusInput(input);
    }
}

function focusInput(input) {
    if (input && input.focus) {
        input.focus();
    }
    else {
        return false;
    }
}