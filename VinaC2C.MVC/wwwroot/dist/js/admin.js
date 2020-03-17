"use strict";

$(document).ready(function () {
	if (!("Notification" in window)) {
		console.log("This browser does not support desktop notification");
	}

	else if (Notification.permission === "granted") {
		var notification = new Notification("Hi there!");
		notify();
	}

	else if (Notification.permission !== "denied") {
		Notification.requestPermission().then(function (permission) {
			console.log(permission);
			if (permission === "granted") {
				var notification = new Notification("Hi there!");
				console.log(notification);
			}
		});
	}
});

function onReloadGrid(gridName) {
    $('#' + gridName).jsGrid("loadData");
}

let connection = new signalR.HubConnectionBuilder().withUrl("/signalServer").build();

connection.on('dataChangeNotification', () => {
    console.log('Hello');
    $.notify('Có Thằng Thay Đổi Dữ Liệu. Mày Đã Thành Công', 'success');
});

connection.start();