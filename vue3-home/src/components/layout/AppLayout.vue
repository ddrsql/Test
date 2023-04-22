<script setup lang="ts">
// import AppHeader from './AppHeader.vue'
// import AppPageWrapper from './AppPageWrapper.vue'
import { onMounted ,reactive} from 'vue'
import "@/mock/index.ts";
import mockApi from "@/api/mockApi";
import  { TestExport } from "@/api/testexport";
import type { User } from "@/api/testexport";


//页面数据请求
let tableData = reactive([]);
const getList = () => {
 mockApi
   .findAll()
   .then((res) => {
        console.log(res)
     if (res.code === "0"){ 
      tableData.push.apply(tableData, res.data);
      }
    })
    .catch(function (error) {
      console.log(error);
    });
};


    let editUser: User = {
        account: "ddrsql",
        password: "asdf",
        address: "asdf@asdf.com",
    };
//添加用户
    const addUser =() => {
        mockApi
            .addUser(editUser)
            .then((res) => {
                console.log(res)
                if (res.code === "0") {
                    console.log("保存成功");
                }
            })
            .catch(function (error) {
                console.log(error);
            });
    };


onMounted(() => {
    console.log("AppLayout");
    getList(); //直接调用请求方法
    addUser();
    TestExport();
});
</script>

<template>
<div class="page">
    <AppHeader/>
     <div class="page-wrapper">
        <RouterView /> <!-- 嵌套路由 <AppPageWrapper/> -->
        <AppFooter/>
    </div>
</div>
    <!-- <div id="container" style="width:1200px">
        <div id="header" style="background-color:#FFA500;">
            <h1 style="margin-bottom:0;">主要的网页标题</h1>
        </div>
        <div id="menu" 
        style="background-color:#FFD700;height:200px;width:100px;float:left;">
            <b>菜单</b><br>HTML<br>CSS<br>JavaScript
        </div>
        <div id="content" 
        style="background-color:#EEEEEE;height:200px;width:600px;float:left;">
            内容在这里
        </div>
        <div id="footer" 
        style="background-color:#FFA500;clear:both;text-align:center;">
            版权 © runoob.com
        </div>
    </div> -->
</template>

<style scoped lang="scss">
</style>