## Đối tượng sử dụng
- Người sử dụng hệ thống này là quản trị viên bệnh viện, bác sĩ, nhân viên thu ngân, nhân viên y tế, bệnh nhân.
- Mỗi người dùng của hệ thống có id người dùng, mật khẩu và chức vụ khác nhau. Họ có thể truy cập một phần của toàn bộ hệ thống dựa trên vai trò của họ.
## Mô tả hoạt động chung:
- Quản trị viên: có thể bổ nhiệm bác sĩ, nhân viên y tế, nhân viên thu ngân, sẽ đăng ký bệnh nhân mới, quản lý kho thuốc, đăng ký phân bố phòng cho bệnh nhân (nếu bệnh nhân nội trú). Họ cũng sẽ phục vụ BN dưới sự hướng dẫn của bác sĩ điều trị, cung cấp tất cả các dịch vụ điều trị y tế cho BN. Những chi tiết dịch vụ này sẽ được lưu trữ trong CSDL để chuẩn bị hóa đơn.
- Bác sĩ: sẽ thăm khám bệnh nhân và kê đơn thuốc cho BN.
- Dược sĩ: Quản lý kho thuốc của bệnh viện: kiểm tra tồn kho, nhập xuất thuốc, cung cấp thuốc theo đơn thuốc của bác sĩ.
- Nhân viên thu ngân: tạo hóa đơn cho bệnh nhân bao gồm tất cả các khoản chi phí (khám, thuốc, dịch vụ điều trị) và cập nhật trạng thái thanh toán.

## Nghiệp vụ chính
1.	Quản lý phòng
Quản trị viên:
- Xác nhận thông tin về số giường, phòng trống.
- Gán phòng cho bệnh nhân nội trú mới và lưu thông tin vào cơ sở dữ liệu.
- Bệnh nhân xuất viện thì xóa thông tin bệnh nhân khỏi danh sách phòng.
- Lưu thông tin phòng vào hồ sơ bệnh nhân và cập nhật vào cơ sở dữ liệu.
2.	Quản lý điều trị
- Bác sĩ:
  - Kiểm tra lịch sử điều trị của bệnh nhân.
  - Sau khi thăm khám, xác định bệnh nhân cần kê thuốc.
  - Tìm kiếm và chọn thuốc từ danh sách thuốc trong kho thuốc
  - Ghi thông tin về liều lượng, cách sử dụng. . .
  - Thêm dịch vụ bệnh nhân cần và yêu cầu sử dụng.
  - Lưu đơn thuốc và dịch vụ sử dụng vào hồ sơ bệnh nhân và cập nhật vào cơ sở dữ liệu.
- Quản trị viên:
  - Kiểm tra tình trạng phòng còn trống giường bệnh hay không để thêm bệnh nhân.
  - Thêm bệnh nhân vào phòng bệnh.
  - Lưu thông tin vào hồ sơ bệnh nhân và cập nhật vào cơ sở dữ liệu.
- Dược sĩ:
  -  Kiểm tra danh sách thuốc và số lượng trong kho.
  -  Cập nhật số lượng sau mỗi lần sử dụng hoặc nhập thêm thuốc.
  -  Cập nhật hạn sử dụng của thuốc, loại bỏ những thuốc hết hạn sử dụng.
3.	Quản lý hóa đơn
- Nhân viên thu ngân:
  - Tìm kiếm thông tin bệnh nhân trong hệ thống.
  - Xem chi tiết về các dịch vụ và đơn thuốc đã được sử dụng.
  - Tạo hóa đơn dựa trên thông tin này và tính tổng chi phí.
  - Gửi hóa đơn cho bệnh nhân và cập nhật trạng thái thanh toán.
 
## This repo has contributon of [phamthuhue](https://github.com/phamthuhue) and [nguyenvang12003454](https://github.com/nguyenvang12003454)
