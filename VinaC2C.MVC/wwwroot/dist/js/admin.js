"use strict";

/**
 * Notification
 * */
$(".toast").toast({
	delay: 1000
});

function showNotification(content) {
	$('#element').toast('show');
}

function hideNotification(content) {
	$('#element').toast('hide');
}
$(document).ready(function () {
	if (!("Notification" in window)) {
		console.log("This browser does not support desktop notification");
	}

	else if (Notification.permission === "granted") {
		
	}

	else if (Notification.permission !== "denied") {
		Notification.requestPermission().then(function (permission) {
			console.log(permission);
			if (permission === "granted") {
			}
		});
	}
});

function notifyAtSystem() {
	var notification = new Notification('Thay Đổi Dữ Liệu', {
		icon: 'http://carnes.cc/jsnuggets/avatar.jpg',
		body: "Có thằng thay đổi dữ liệu",
	});

	notification.onclick = function () {
		window.open("http://carnes.cc");
	};
	setTimeout(notification.close.bind(notification), 7000);
}

/**
 * Reload Grid
 * @param {any} gridName
 */
function onReloadGrid(gridName) {
    $('#' + gridName).jsGrid("loadData");
}

/**
 * Connect Hub
 * */
let connection = new signalR.HubConnectionBuilder().withUrl("/signalServer").build();

connection.on('dataChangeNotification', () => {
    console.log('Hello');
	$.notify('Có Thằng Thay Đổi Dữ Liệu. Mày Đã Thành Công', 'success');
	notifyAtSystem();
});

connection.start();

