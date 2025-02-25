# 체크섬을 사용한 TCP 통신 프로토콜

## 개요

이 프로젝트는 데이터 무결성을 보장하고 클라이언트와 서버 간의 실시간 통신을 가능하게 하는 맞춤형 TCP 통신 프로토콜을 구현

- **Length**: 패킷의 총 길이 (필수)
- **Checksum**: 데이터 무결성 검증을 위한 체크섬 (필수)
- **CommandCode**: 수행할 명령을 구분하는 코드 (필수)
- **Data**: 명령에 필요한 데이터 (필수)
- **EndByte**: 패킷의 끝을 나타내는 바이트 (선택적)

## 아키텍처

### 서버 측 구현

서버는 클라이언트로부터 받은 명령과 데이터를 처리하고, 필요한 작업을 수행한 후 클라이언트에게 응답을 보내는 역할

서버는 다음과 같은 작업을 수행
1. 들어오는 TCP 연결을 수락합니다.
2. 수신된 패킷을 정의된 구조(`Length + Checksum + CommandCode + Data + EndByte`)에 맞게 파싱합니다.
3. `CommandCode`를 기반으로 명령을 수행하고 데이터를 수정합니다.
4. 수정된 값을 클라이언트에게 전송합니다. 서버는 실제 데이터를 보유하고 있어야 하며, 데이터에 대한 권한을 가져야 합니다.

### 클라이언트 측 구현

클라이언트는 서버에게 명령을 보내고 서버로부터 응답을 받는 역할을 합니다. 클라이언트는 C#과 WinForms 인터페이스를 사용하여 개발되며, 도구상자에서 드래그 앤 드롭 방식으로 구성 요소를 쉽게 추가할 수 있습니다.

- 클라이언트는 서버에 패킷을 전송하고, 서버는 값을 수정하여 클라이언트에게 응답을 보냅니다.
- 클라이언트는 서버로부터 응답을 받은 후, 수정된 값과 상태를 표시합니다.

## 해결해야 할 문제

1. **서버 데이터 처리**: 현재 클라이언트가 값을 보유하고 명령을 서버에 보냅니다. 하지만 서버는 실제 데이터를 보유하고 이를 수정한 후, 수정된 값을 클라이언트에게 보내야 합니다. 서버가 데이터의 권한을 가져야 합니다.
   
2. **패킷 전송**: 현재 서버는 클라이언트에게 수정된 값을 보내고 있지 않습니다. 서버가 값을 수정한 후, 이를 클라이언트에게 전송하는 기능을 구현해야 합니다.

