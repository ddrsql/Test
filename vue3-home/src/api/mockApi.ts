import http from "./http";
import type { User } from "./testexport";

export default {
 
  //用户列表
  findAll() {
    return http({
      url: `/api/mockGetList`,
      method: "get",
    });
  },
 
  //添加用户
  addUser(user:User) {
    return http({
      url: `/api/add`,
      method: "post",
      data: user,
    });
  },
}