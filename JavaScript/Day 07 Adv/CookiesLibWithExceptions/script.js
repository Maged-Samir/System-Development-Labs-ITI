function getCookies(cookieName) {

    if (arguments.length != 1 || typeof arguments[0] != 'string') {
        throw new Error("Must pass only one string argument")
    }

    var cookies = document.cookie.split(';');

    for (var cookie of cookies) {
        cookie = cookie.split('=');
        if (cookie[0].trim() === cookieName) {
            return cookie[1];
        }
    }

    throw new Error("Cookie not found");
}

function deleteCookies(cookieName) {

    if (arguments.length != 1 || typeof arguments[0] != 'string') {
        throw new Error("Must pass only one string argument")
    }

    if (!hasCookie(cookieName)) {
        throw new Error("Cookie not found");
    }

    document.cookie = cookieName + '=;expires=Thu, 01 Jan 1970 00:00:01 GMT;';
}

function setCookie(cookieName, cookieValue, expiryDate) {

    if (arguments.length < 2 || typeof arguments[0] != 'string') {
        throw new Error("Must pass at least two string arguments for key and value")
    } else if (arguments.length === 3 && (Object.prototype.toString.call(arguments[2]) !== "[object Date]" || isFinite(arguments[2]))) {
        throw new Error("Third argument of expiryDate must be a date or number")
    }

    if (!!expiryDate) {
        document.cookie = `${cookieName}=${cookieValue};expires=${expiryDate};SameSite=Lax`;
    } else {
        document.cookie = `${cookieName}=${cookieValue};SameSite=Lax`;
    }
}

function allCookieList() {
    var cookies = document.cookie.split(';');
    var result = [];

    for (var cookie of cookies) {
        cookie = cookie.split('=');
        result[cookie[0].trim() ] = cookie[1];
    }

    return result;
}

function hasCookie(cookieName) {
    if (arguments.length != 1 || typeof arguments[0] != 'string') {
        throw new Error("Must pass only one string argument")
    }

    var cookies = document.cookie.split(';');

    for (var cookie of cookies) {
        cookie = cookie.split('=');
        if (cookie[0].trim() === cookieName) {
            return true;
        }
    }

    return false;
}