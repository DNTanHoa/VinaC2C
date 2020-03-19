"use strict";

let currentUser = "admin";

let chatConnection = new signalR.HubConnectionBuilder().withUrl("/chatServer").build();
$("#SendButton").attr("disabled", true);

chatConnection.on("ReceiveMessage", (user,message) => {
    var content = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    console.log(content);
    if (user != $("#userInput").val()) {
        var htmlResult = ReceiveMesageToHtml(content, user);
        $(".direct-chat-messages").append(htmlResult);
    }
})

$(document).ready(() => {
    $("#SendButton").on("click", () => {
        var message = $("#messageInput").val();
        var user = $("#userInput").val();
        var htmlResult = SendMesageToHtml(message, user);
        $(".direct-chat-messages").append(htmlResult);
        chatConnection.invoke("SendMessage", user, message);
    });
})

chatConnection.start().then(() => {
    $("#SendButton").attr("disabled", false);
}).catch((err) => {
    console.log(err);
});

chatConnection.on()

function ReceiveMesageToHtml(content,user) {
    var htmlResult = '<div class="direct-chat-msg">' +
                         '<div class="direct-chat-infos clearfix">' +
                            '<span class="direct-chat-name float-left">' +
                                user +
                            '</span>' +
                        '</div>' +
                        '<img class="direct-chat-img" src="images/user_avatar.png" alt="message user image">' +
                        '<div class="direct-chat-text">' +
                            content
                        '</div>' +
                    '</div>';
    return htmlResult;
}

function SendMesageToHtml(content, user) {
    var htmlResult = '<div class="direct-chat-msg right">' +
                        '<div class="direct-chat-infos clearfix">' +
                            '<span class="direct-chat-name float-right">' +
                                 user +
                            '</span>' +
                        '</div>' +
                        '<img class="direct-chat-img" src="images/user_avatar.png" alt="message user image">' +
                        '<div class="direct-chat-text">' +
                             content
                         '</div>' +
                    '</div>';
    return htmlResult;
}
