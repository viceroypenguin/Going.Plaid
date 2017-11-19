var app = {
    post: function (url, data, callback) {
        var request = new XMLHttpRequest();
        request.open("POST", url, true);
        request.setRequestHeader("Content-Type", "application/json; charset=UTF-8");
        request.onreadystatechange = function () {
            if (this.readyState === 4) {
                if (callback) { callback(JSON.parse(this.responseText)); }
            }
        };
        request.send(JSON.stringify(data));
    },

    showPopup: function (message) {
        console.log("popup message:" + message);
    }
};