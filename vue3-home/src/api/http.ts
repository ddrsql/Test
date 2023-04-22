import axios from "axios";
 
let http = axios.create({
  baseURL: "",
  timeout: 10000,
});

// 拦截器的添加
http.interceptors.request.use(
  (config) => {
    console.log("加载中");
    return config;
  },
  (err) => {
    console.log("网络异常");
    return Promise.reject(err);
  }
);
 
//响应拦截器
http.interceptors.response.use(
  (res) => {
    return res.data;
  },
  (err) => {
    console.log("请求失败");
    return Promise.reject(err);
  }
);
export default http;