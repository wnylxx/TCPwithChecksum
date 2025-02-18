const net = require('net'); 

let panTilt = { height: 0, position: 0 }; //팬틸트 초기화
let zoomLevel = 0.5; // 줌 초기화
let volumeLevel = 10; // 볼륨 초기화

// TCP 서버 연결
const tcpServer = net.createServer((socket) => {
    console.log('클라이언트 연결됨');

    socket.on('data', (data) => {
        const packet = parsePacket(data);

        // 체크섬 확인
        
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

}


// 팬틸트 명령 처리 함수
function handlePanTilt(packet) {

}


// 줌 명령 처리 함수
function handleZoom(packet) {

}

// 볼륨 명령 처리 함수
function handleVolume(packet) {
    
}