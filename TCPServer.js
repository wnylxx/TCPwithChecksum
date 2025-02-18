const net = require('net'); 

let panTilt = { height: 0, position: 0 }; //팬틸트 초기화
let zoomLevel = 0; // 줌 초기화
let volumeLevel = 10; // 볼륨 초기화

// TCP 서버 연결
const tcpServer = net.createServer((socket) => {
    console.log('클라이언트 연결됨');

    socket.on('data', (data) => {
        const packet = parsePacket(data);

        // 체크섬 확인
        if (checkChecksum(packet)) {
            console.log('체크섬 확인됨');

            // 명령 처리
            handleCommand(packet);

            // 클라이언트에 명렁 처리 완료 메시지 전송
            socket.write('명령 처리 완료');
        } else {
            console.log('체크섬 오류');
            socket.write('체크섬 오류');
        }
    });

    socket.on('end', () => {
        console.log('클라이언트 연결 종료');
    });

});


const TCP_PORT = 5000;

tcpServer.listen(TCP_PORT, () => {
    console.log('서버가 포트 5000에서 시작되었습니다.')
});


// 패킷 파싱 함수
function parsePacket(data) {
    return {
        commandCode: data.readUInt8(0),  // 명령 코드
        action: data.readUInt8(1),
        endByte: data.readUInt8(2), 
    };
}

// 체크섬 계산 함수
function checkChecksum(packet) {
    return packet.endByte === 0xFF;
}

// 명령 처리 함수
function handleCommand(packet) {
    switch (packet.commandCode) {
        case 1:
            handlePanTilt(packet);
            break;
        case 2:
            handleZoom(packet);
            break;
        case 3:
            handleVolume(packet);
            break;
        default:
            console.log('알 수 없는 명령')
    }
}


// 팬틸트 명령 처리 함수
function handlePanTilt(packet) {
    if (packet.action === 1) {
        panTilt.height += 1;
        console.log(`팬틸트 높이값 +1: ${panTilt.height}`);
    } else if (packet.action === -1) {
        panTilt.height -= 1;
        console.log(`팬틸트 높이값 -1: ${panTilt.height}`);
    } else if (packet.action === 2) {
        panTilt.position += 1;  // 우 방향
        console.log(`팬틸트 위치값 +1: ${panTilt.position}`);
    } else if (packet.action === -2) {
        panTilt.position -= 1;  // 좌 방향
        console.log(`팬틸트 위치값 -1: ${panTilt.position}`);
    } else {
        console.log("잘못된 팬틸트 명령")
    }
}


// 줌 명령 처리 함수
function handleZoom(packet) {
    if (packet.action === 1 && zoomLevel <= 0.9){
        zoomLevel += 0.1;
        console.log(`줌 +1: ${zoomLevel}`);
    } else if (packet.action === -1 && zoomLevel >= 0.1) {
        zoomLevel -= 0.1;
        console.log(`줌 -1: ${zoomLevel}`);
    } else {
        console.log("잘못된 줌 명령")
    }
}

// 볼륨 명령 처리 함수
function handleVolume(packet) {
    if(packet.action === 1 && volumeLevel < 100) {
        volumeLevel += 1;
        console.log(`볼륨 +1: ${volumeLevel}`);
    } else if (packet.action === 1 && volumeLevel > 0) {
        volumeLevel -= 1;
        console.log(`볼륨 -1: ${volumeLevel}`);
    }
}