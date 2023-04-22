<script setup lang="ts">
import AppFooter from './AppFooter.vue'
</script>

<template>

  <!-- carousel -->
    <div style="height:200px">
      <div id="carousel-indicators" class="carousel slide" data-bs-ride="carousel">
          <div class="carousel-indicators">
            <button type="button" data-bs-target="#carousel-indicators" data-bs-slide-to="0" class=" active"></button>
            <button type="button" data-bs-target="#carousel-indicators" data-bs-slide-to="1" class=""></button>
          </div>
          <div class="carousel-inner">
            <div class="carousel-item active" style="height:200px">
                <img class="d-block w-100" alt="" src="../../assets/photos/home-office-desk-with-macbook-iphone-calendar-watch-and-organizer.jpg">
            </div>
            <div class="carousel-item" style="height:200px">
                <img class="d-block w-100" alt="" src="../../assets/photos/young-woman-working-in-a-cafe.jpg">
            </div>
          </div>
      </div>
    </div>
    <!-- Page body -->
    <div class="page-body">
        <div class="container">
            <div class="row row-cards">
                <div class="col-md-12 col-lg-8">
                    <div class="row row-cards">
                  <div class="space-y">
                    <div class="card">
                      <div class="row g-0">
                        <div class="col-auto">
                          <div class="card-body">
                            <div class="avatar avatar-md" style="background-image: url(src/assets/jobs/job-1.jpg)"></div>
                          </div>
                        </div>
                        <div class="col">
                          <div class="card-body ps-0">
                            <div class="row">
                              <div class="col">
                                <h3 class="mb-0"><a href="#">title</a></h3>
                              </div>
                            </div>
                            <div class="row">
                              <div class="col-md">
                                <div class="mt-3 list-inline list-inline-dots mb-0 text-muted d-sm-block d-none">
                                  <div class="list-inline-item"><!-- Download SVG icon from http://tabler-icons.io/i/building-community -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M8 9l5 5v7h-5v-4m0 4h-5v-7l5 -5m1 1v-6a1 1 0 0 1 1 -1h10a1 1 0 0 1 1 1v17h-8"></path><path d="M13 7l0 .01"></path><path d="M17 7l0 .01"></path><path d="M17 11l0 .01"></path><path d="M17 15l0 .01"></path></svg>
                                    CMS Max</div>
                                  <div class="list-inline-item"><!-- Download SVG icon from http://tabler-icons.io/i/license -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M15 21h-9a3 3 0 0 1 -3 -3v-1h10v2a2 2 0 0 0 4 0v-14a2 2 0 1 1 2 2h-2m2 -4h-11a3 3 0 0 0 -3 3v11"></path><path d="M9 7l4 0"></path><path d="M9 11l4 0"></path></svg>
                                    Full-time</div>
                                  <div class="list-inline-item"><!-- Download SVG icon from http://tabler-icons.io/i/map-pin -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M12 11m-3 0a3 3 0 1 0 6 0a3 3 0 1 0 -6 0"></path><path d="M17.657 16.657l-4.243 4.243a2 2 0 0 1 -2.827 0l-4.244 -4.243a8 8 0 1 1 11.314 0z"></path></svg>
                                    Remote / USA</div>
                                </div>
                                <div class="mt-3 list mb-0 text-muted d-block d-sm-none">
                                  <div class="list-item"><!-- Download SVG icon from http://tabler-icons.io/i/building-community -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M8 9l5 5v7h-5v-4m0 4h-5v-7l5 -5m1 1v-6a1 1 0 0 1 1 -1h10a1 1 0 0 1 1 1v17h-8"></path><path d="M13 7l0 .01"></path><path d="M17 7l0 .01"></path><path d="M17 11l0 .01"></path><path d="M17 15l0 .01"></path></svg>
                                    CMS Max</div>
                                  <div class="list-item"><!-- Download SVG icon from http://tabler-icons.io/i/license -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M15 21h-9a3 3 0 0 1 -3 -3v-1h10v2a2 2 0 0 0 4 0v-14a2 2 0 1 1 2 2h-2m2 -4h-11a3 3 0 0 0 -3 3v11"></path><path d="M9 7l4 0"></path><path d="M9 11l4 0"></path></svg>
                                    Full-time</div>
                                  <div class="list-item"><!-- Download SVG icon from http://tabler-icons.io/i/map-pin -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M12 11m-3 0a3 3 0 1 0 6 0a3 3 0 1 0 -6 0"></path><path d="M17.657 16.657l-4.243 4.243a2 2 0 0 1 -2.827 0l-4.244 -4.243a8 8 0 1 1 11.314 0z"></path></svg>
                                    Remote / USA</div>
                                </div>
                              </div>
                              <div class="col-md-auto">
                                <div class="mt-3 badges">
                                  <a href="#" class="badge badge-outline text-muted border fw-normal badge-pill">.Net Core</a>
                                  <a href="#" class="badge badge-outline text-muted border fw-normal badge-pill">Laravel</a>
                                  <a href="#" class="badge badge-outline text-muted border fw-normal badge-pill">CSS</a>
                                  <a href="#" class="badge badge-outline text-muted border fw-normal badge-pill">Vue</a>
                                </div>
                              </div>
                            </div>
                          </div>
                        </div>
                      </div>
                    </div>
                    <div class="card">
                      <div class="row g-0">
                        <div class="col-auto">
                          <div class="card-body">
                            <div class="avatar avatar-md" style="background-image: url(src/assets/jobs/job-2.png)"></div>
                          </div>
                        </div>
                        <div class="col">
                          <div class="card-body ps-0">
                            <div class="row">
                              <div class="col">
                                <h3 class="mb-0"><a href="#">哈哈😄</a></h3>
                              </div>
                              <div class="col-auto fs-3 text-green">$140,000 - $180,000</div>
                            </div>
                            <div class="row">
                              <div class="col-md">
                                <div class="mt-3 list-inline list-inline-dots mb-0 text-muted d-sm-block d-none">
                                  <div class="list-inline-item"><!-- Download SVG icon from http://tabler-icons.io/i/building-community -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M8 9l5 5v7h-5v-4m0 4h-5v-7l5 -5m1 1v-6a1 1 0 0 1 1 -1h10a1 1 0 0 1 1 1v17h-8"></path><path d="M13 7l0 .01"></path><path d="M17 7l0 .01"></path><path d="M17 11l0 .01"></path><path d="M17 15l0 .01"></path></svg>
                                    Center Pixel, Inc</div>
                                  <div class="list-inline-item"><!-- Download SVG icon from http://tabler-icons.io/i/license -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M15 21h-9a3 3 0 0 1 -3 -3v-1h10v2a2 2 0 0 0 4 0v-14a2 2 0 1 1 2 2h-2m2 -4h-11a3 3 0 0 0 -3 3v11"></path><path d="M9 7l4 0"></path><path d="M9 11l4 0"></path></svg>
                                    Full-time or Contract</div>
                                  <div class="list-inline-item"><!-- Download SVG icon from http://tabler-icons.io/i/map-pin -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M12 11m-3 0a3 3 0 1 0 6 0a3 3 0 1 0 -6 0"></path><path d="M17.657 16.657l-4.243 4.243a2 2 0 0 1 -2.827 0l-4.244 -4.243a8 8 0 1 1 11.314 0z"></path></svg>
                                    Remote / Palo Alto, CA</div>
                                </div>
                                <div class="mt-3 list mb-0 text-muted d-block d-sm-none">
                                  <div class="list-item"><!-- Download SVG icon from http://tabler-icons.io/i/building-community -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M8 9l5 5v7h-5v-4m0 4h-5v-7l5 -5m1 1v-6a1 1 0 0 1 1 -1h10a1 1 0 0 1 1 1v17h-8"></path><path d="M13 7l0 .01"></path><path d="M17 7l0 .01"></path><path d="M17 11l0 .01"></path><path d="M17 15l0 .01"></path></svg>
                                    Center Pixel, Inc</div>
                                  <div class="list-item"><!-- Download SVG icon from http://tabler-icons.io/i/license -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M15 21h-9a3 3 0 0 1 -3 -3v-1h10v2a2 2 0 0 0 4 0v-14a2 2 0 1 1 2 2h-2m2 -4h-11a3 3 0 0 0 -3 3v11"></path><path d="M9 7l4 0"></path><path d="M9 11l4 0"></path></svg>
                                    Full-time or Contract</div>
                                  <div class="list-item"><!-- Download SVG icon from http://tabler-icons.io/i/map-pin -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M12 11m-3 0a3 3 0 1 0 6 0a3 3 0 1 0 -6 0"></path><path d="M17.657 16.657l-4.243 4.243a2 2 0 0 1 -2.827 0l-4.244 -4.243a8 8 0 1 1 11.314 0z"></path></svg>
                                    Remote / Palo Alto, CA</div>
                                </div>
                              </div>
                              <div class="col-md-auto">
                                <div class="mt-3 badges">
                                  <a href="#" class="badge badge-outline text-muted border fw-normal badge-pill">HTML</a>
                                  <a href="#" class="badge badge-outline text-muted border fw-normal badge-pill">CSS</a>
                                  <a href="#" class="badge badge-outline text-muted border fw-normal badge-pill">React</a>
                                  <a href="#" class="badge badge-outline text-muted border fw-normal badge-pill">+3</a>
                                </div>
                              </div>
                            </div>
                          </div>
                        </div>
                      </div>
                    </div>
                    <div class="card">
                      <div class="row g-0">
                        <div class="col-auto">
                          <div class="card-body">
                            <div class="avatar avatar-md" style="background-image: url(src/assets/jobs/job-3.png)"></div>
                          </div>
                        </div>
                        <div class="col">
                          <div class="card-body ps-0">
                            <div class="row">
                              <div class="col">
                                <h3 class="mb-0"><a href="#">Principal Web Application Developer</a></h3>
                              </div>
                            </div>
                            <div class="row">
                              <div class="col-md">
                                <div class="mt-3 list-inline list-inline-dots mb-0 text-muted d-sm-block d-none">
                                  <div class="list-inline-item"><!-- Download SVG icon from http://tabler-icons.io/i/building-community -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M8 9l5 5v7h-5v-4m0 4h-5v-7l5 -5m1 1v-6a1 1 0 0 1 1 -1h10a1 1 0 0 1 1 1v17h-8"></path><path d="M13 7l0 .01"></path><path d="M17 7l0 .01"></path><path d="M17 11l0 .01"></path><path d="M17 15l0 .01"></path></svg>
                                    Chicago Botanic Garden</div>
                                  <div class="list-inline-item"><!-- Download SVG icon from http://tabler-icons.io/i/license -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M15 21h-9a3 3 0 0 1 -3 -3v-1h10v2a2 2 0 0 0 4 0v-14a2 2 0 1 1 2 2h-2m2 -4h-11a3 3 0 0 0 -3 3v11"></path><path d="M9 7l4 0"></path><path d="M9 11l4 0"></path></svg>
                                    Full-time</div>
                                  <div class="list-inline-item"><!-- Download SVG icon from http://tabler-icons.io/i/map-pin -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M12 11m-3 0a3 3 0 1 0 6 0a3 3 0 1 0 -6 0"></path><path d="M17.657 16.657l-4.243 4.243a2 2 0 0 1 -2.827 0l-4.244 -4.243a8 8 0 1 1 11.314 0z"></path></svg>
                                    Hybrid / Chicago Botanic Garden</div>
                                </div>
                                <div class="mt-3 list mb-0 text-muted d-block d-sm-none">
                                  <div class="list-item"><!-- Download SVG icon from http://tabler-icons.io/i/building-community -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M8 9l5 5v7h-5v-4m0 4h-5v-7l5 -5m1 1v-6a1 1 0 0 1 1 -1h10a1 1 0 0 1 1 1v17h-8"></path><path d="M13 7l0 .01"></path><path d="M17 7l0 .01"></path><path d="M17 11l0 .01"></path><path d="M17 15l0 .01"></path></svg>
                                    Chicago Botanic Garden</div>
                                  <div class="list-item"><!-- Download SVG icon from http://tabler-icons.io/i/license -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M15 21h-9a3 3 0 0 1 -3 -3v-1h10v2a2 2 0 0 0 4 0v-14a2 2 0 1 1 2 2h-2m2 -4h-11a3 3 0 0 0 -3 3v11"></path><path d="M9 7l4 0"></path><path d="M9 11l4 0"></path></svg>
                                    Full-time</div>
                                  <div class="list-item"><!-- Download SVG icon from http://tabler-icons.io/i/map-pin -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M12 11m-3 0a3 3 0 1 0 6 0a3 3 0 1 0 -6 0"></path><path d="M17.657 16.657l-4.243 4.243a2 2 0 0 1 -2.827 0l-4.244 -4.243a8 8 0 1 1 11.314 0z"></path></svg>
                                    Hybrid / Chicago Botanic Garden</div>
                                </div>
                              </div>
                              <div class="col-md-auto">
                                <div class="mt-3 badges">
                                  <a href="#" class="badge badge-outline text-muted border fw-normal badge-pill">HTML</a>
                                  <a href="#" class="badge badge-outline text-muted border fw-normal badge-pill">PHP</a>
                                  <a href="#" class="badge badge-outline text-muted border fw-normal badge-pill">Laravel</a>
                                </div>
                              </div>
                            </div>
                          </div>
                        </div>
                      </div>
                    </div>
                    <div class="card">
                      <div class="row g-0">
                        <div class="col-auto">
                          <div class="card-body">
                            <div class="avatar avatar-md" style="background-image: url(src/assets/jobs/job-4.png)"></div>
                          </div>
                        </div>
                        <div class="col">
                          <div class="card-body ps-0">
                            <div class="row">
                              <div class="col">
                                <h3 class="mb-0"><a href="#">Front-End Developer</a></h3>
                              </div>
                            </div>
                            <div class="row">
                              <div class="col-md">
                                <div class="mt-3 list-inline list-inline-dots mb-0 text-muted d-sm-block d-none">
                                  <div class="list-inline-item"><!-- Download SVG icon from http://tabler-icons.io/i/building-community -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M8 9l5 5v7h-5v-4m0 4h-5v-7l5 -5m1 1v-6a1 1 0 0 1 1 -1h10a1 1 0 0 1 1 1v17h-8"></path><path d="M13 7l0 .01"></path><path d="M17 7l0 .01"></path><path d="M17 11l0 .01"></path><path d="M17 15l0 .01"></path></svg>
                                    Simple Focus</div>
                                  <div class="list-inline-item"><!-- Download SVG icon from http://tabler-icons.io/i/license -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M15 21h-9a3 3 0 0 1 -3 -3v-1h10v2a2 2 0 0 0 4 0v-14a2 2 0 1 1 2 2h-2m2 -4h-11a3 3 0 0 0 -3 3v11"></path><path d="M9 7l4 0"></path><path d="M9 11l4 0"></path></svg>
                                    Full-time</div>
                                  <div class="list-inline-item"><!-- Download SVG icon from http://tabler-icons.io/i/map-pin -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M12 11m-3 0a3 3 0 1 0 6 0a3 3 0 1 0 -6 0"></path><path d="M17.657 16.657l-4.243 4.243a2 2 0 0 1 -2.827 0l-4.244 -4.243a8 8 0 1 1 11.314 0z"></path></svg>
                                    Remote / USA</div>
                                </div>
                                <div class="mt-3 list mb-0 text-muted d-block d-sm-none">
                                  <div class="list-item"><!-- Download SVG icon from http://tabler-icons.io/i/building-community -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M8 9l5 5v7h-5v-4m0 4h-5v-7l5 -5m1 1v-6a1 1 0 0 1 1 -1h10a1 1 0 0 1 1 1v17h-8"></path><path d="M13 7l0 .01"></path><path d="M17 7l0 .01"></path><path d="M17 11l0 .01"></path><path d="M17 15l0 .01"></path></svg>
                                    Simple Focus</div>
                                  <div class="list-item"><!-- Download SVG icon from http://tabler-icons.io/i/license -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M15 21h-9a3 3 0 0 1 -3 -3v-1h10v2a2 2 0 0 0 4 0v-14a2 2 0 1 1 2 2h-2m2 -4h-11a3 3 0 0 0 -3 3v11"></path><path d="M9 7l4 0"></path><path d="M9 11l4 0"></path></svg>
                                    Full-time</div>
                                  <div class="list-item"><!-- Download SVG icon from http://tabler-icons.io/i/map-pin -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M12 11m-3 0a3 3 0 1 0 6 0a3 3 0 1 0 -6 0"></path><path d="M17.657 16.657l-4.243 4.243a2 2 0 0 1 -2.827 0l-4.244 -4.243a8 8 0 1 1 11.314 0z"></path></svg>
                                    Remote / USA</div>
                                </div>
                              </div>
                              <div class="col-md-auto">
                                <div class="mt-3 badges">
                                  <a href="#" class="badge badge-outline text-muted border fw-normal badge-pill">HTML</a>
                                  <a href="#" class="badge badge-outline text-muted border fw-normal badge-pill">PHP</a>
                                  <a href="#" class="badge badge-outline text-muted border fw-normal badge-pill">CSS</a>
                                  <a href="#" class="badge badge-outline text-muted border fw-normal badge-pill">+2</a>
                                </div>
                              </div>
                            </div>
                          </div>
                        </div>
                      </div>
                    </div>
                    <div class="card">
                      <div class="row g-0">
                        <div class="col-auto">
                          <div class="card-body">
                            <div class="avatar avatar-md" style="background-image: url(src/assets/jobs/job-5.png)"></div>
                          </div>
                        </div>
                        <div class="col">
                          <div class="card-body ps-0">
                            <div class="row">
                              <div class="col">
                                <h3 class="mb-0"><a href="#">Senior Front-End Engineer</a></h3>
                              </div>
                            </div>
                            <div class="row">
                              <div class="col-md">
                                <div class="mt-3 list-inline list-inline-dots mb-0 text-muted d-sm-block d-none">
                                  <div class="list-inline-item"><!-- Download SVG icon from http://tabler-icons.io/i/building-community -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M8 9l5 5v7h-5v-4m0 4h-5v-7l5 -5m1 1v-6a1 1 0 0 1 1 -1h10a1 1 0 0 1 1 1v17h-8"></path><path d="M13 7l0 .01"></path><path d="M17 7l0 .01"></path><path d="M17 11l0 .01"></path><path d="M17 15l0 .01"></path></svg>
                                    Infinia ML</div>
                                  <div class="list-inline-item"><!-- Download SVG icon from http://tabler-icons.io/i/license -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M15 21h-9a3 3 0 0 1 -3 -3v-1h10v2a2 2 0 0 0 4 0v-14a2 2 0 1 1 2 2h-2m2 -4h-11a3 3 0 0 0 -3 3v11"></path><path d="M9 7l4 0"></path><path d="M9 11l4 0"></path></svg>
                                    Full-time</div>
                                  <div class="list-inline-item"><!-- Download SVG icon from http://tabler-icons.io/i/map-pin -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M12 11m-3 0a3 3 0 1 0 6 0a3 3 0 1 0 -6 0"></path><path d="M17.657 16.657l-4.243 4.243a2 2 0 0 1 -2.827 0l-4.244 -4.243a8 8 0 1 1 11.314 0z"></path></svg>
                                    Durham, NC</div>
                                </div>
                                <div class="mt-3 list mb-0 text-muted d-block d-sm-none">
                                  <div class="list-item"><!-- Download SVG icon from http://tabler-icons.io/i/building-community -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M8 9l5 5v7h-5v-4m0 4h-5v-7l5 -5m1 1v-6a1 1 0 0 1 1 -1h10a1 1 0 0 1 1 1v17h-8"></path><path d="M13 7l0 .01"></path><path d="M17 7l0 .01"></path><path d="M17 11l0 .01"></path><path d="M17 15l0 .01"></path></svg>
                                    Infinia ML</div>
                                  <div class="list-item"><!-- Download SVG icon from http://tabler-icons.io/i/license -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M15 21h-9a3 3 0 0 1 -3 -3v-1h10v2a2 2 0 0 0 4 0v-14a2 2 0 1 1 2 2h-2m2 -4h-11a3 3 0 0 0 -3 3v11"></path><path d="M9 7l4 0"></path><path d="M9 11l4 0"></path></svg>
                                    Full-time</div>
                                  <div class="list-item"><!-- Download SVG icon from http://tabler-icons.io/i/map-pin -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M12 11m-3 0a3 3 0 1 0 6 0a3 3 0 1 0 -6 0"></path><path d="M17.657 16.657l-4.243 4.243a2 2 0 0 1 -2.827 0l-4.244 -4.243a8 8 0 1 1 11.314 0z"></path></svg>
                                    Durham, NC</div>
                                </div>
                              </div>
                              <div class="col-md-auto">
                                <div class="mt-3 badges">
                                  <a href="#" class="badge badge-outline text-muted border fw-normal badge-pill">HTML</a>
                                  <a href="#" class="badge badge-outline text-muted border fw-normal badge-pill">PHP</a>
                                  <a href="#" class="badge badge-outline text-muted border fw-normal badge-pill">CSS</a>
                                  <a href="#" class="badge badge-outline text-muted border fw-normal badge-pill">+4</a>
                                </div>
                              </div>
                            </div>
                          </div>
                        </div>
                      </div>
                    </div>
                    <div class="card">
                      <div class="row g-0">
                        <div class="col-auto">
                          <div class="card-body">
                            <div class="avatar avatar-md" style="background-image: url(src/assets/jobs/job-6.png)"></div>
                          </div>
                        </div>
                        <div class="col">
                          <div class="card-body ps-0">
                            <div class="row">
                              <div class="col">
                                <h3 class="mb-0"><a href="#">Senior Web Developer, Open Source</a></h3>
                              </div>
                            </div>
                            <div class="row">
                              <div class="col-md">
                                <div class="mt-3 list-inline list-inline-dots mb-0 text-muted d-sm-block d-none">
                                  <div class="list-inline-item"><!-- Download SVG icon from http://tabler-icons.io/i/building-community -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M8 9l5 5v7h-5v-4m0 4h-5v-7l5 -5m1 1v-6a1 1 0 0 1 1 -1h10a1 1 0 0 1 1 1v17h-8"></path><path d="M13 7l0 .01"></path><path d="M17 7l0 .01"></path><path d="M17 11l0 .01"></path><path d="M17 15l0 .01"></path></svg>
                                    Crowd Favorite</div>
                                  <div class="list-inline-item"><!-- Download SVG icon from http://tabler-icons.io/i/license -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M15 21h-9a3 3 0 0 1 -3 -3v-1h10v2a2 2 0 0 0 4 0v-14a2 2 0 1 1 2 2h-2m2 -4h-11a3 3 0 0 0 -3 3v11"></path><path d="M9 7l4 0"></path><path d="M9 11l4 0"></path></svg>
                                    Full-time</div>
                                  <div class="list-inline-item"><!-- Download SVG icon from http://tabler-icons.io/i/map-pin -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M12 11m-3 0a3 3 0 1 0 6 0a3 3 0 1 0 -6 0"></path><path d="M17.657 16.657l-4.243 4.243a2 2 0 0 1 -2.827 0l-4.244 -4.243a8 8 0 1 1 11.314 0z"></path></svg>
                                    Remote / USA</div>
                                </div>
                                <div class="mt-3 list mb-0 text-muted d-block d-sm-none">
                                  <div class="list-item"><!-- Download SVG icon from http://tabler-icons.io/i/building-community -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M8 9l5 5v7h-5v-4m0 4h-5v-7l5 -5m1 1v-6a1 1 0 0 1 1 -1h10a1 1 0 0 1 1 1v17h-8"></path><path d="M13 7l0 .01"></path><path d="M17 7l0 .01"></path><path d="M17 11l0 .01"></path><path d="M17 15l0 .01"></path></svg>
                                    Crowd Favorite</div>
                                  <div class="list-item"><!-- Download SVG icon from http://tabler-icons.io/i/license -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M15 21h-9a3 3 0 0 1 -3 -3v-1h10v2a2 2 0 0 0 4 0v-14a2 2 0 1 1 2 2h-2m2 -4h-11a3 3 0 0 0 -3 3v11"></path><path d="M9 7l4 0"></path><path d="M9 11l4 0"></path></svg>
                                    Full-time</div>
                                  <div class="list-item"><!-- Download SVG icon from http://tabler-icons.io/i/map-pin -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M12 11m-3 0a3 3 0 1 0 6 0a3 3 0 1 0 -6 0"></path><path d="M17.657 16.657l-4.243 4.243a2 2 0 0 1 -2.827 0l-4.244 -4.243a8 8 0 1 1 11.314 0z"></path></svg>
                                    Remote / USA</div>
                                </div>
                              </div>
                              <div class="col-md-auto">
                                <div class="mt-3 badges">
                                  <a href="#" class="badge badge-outline text-muted border fw-normal badge-pill">HTML</a>
                                  <a href="#" class="badge badge-outline text-muted border fw-normal badge-pill">JavaScript</a>
                                  <a href="#" class="badge badge-outline text-muted border fw-normal badge-pill">CSS</a>
                                  <a href="#" class="badge badge-outline text-muted border fw-normal badge-pill">+8</a>
                                </div>
                              </div>
                            </div>
                          </div>
                        </div>
                      </div>
                    </div>
                    <div class="card">
                      <div class="row g-0">
                        <div class="col-auto">
                          <div class="card-body">
                            <div class="avatar avatar-md" style="background-image: url(src/assets/jobs/job-7.png)"></div>
                          </div>
                        </div>
                        <div class="col">
                          <div class="card-body ps-0">
                            <div class="row">
                              <div class="col">
                                <h3 class="mb-0"><a href="#">Frontend Engineer</a></h3>
                              </div>
                              <div class="col-auto fs-3 text-green">$95,000 – $145,000 USD</div>
                            </div>
                            <div class="row">
                              <div class="col-md">
                                <div class="mt-3 list-inline list-inline-dots mb-0 text-muted d-sm-block d-none">
                                  <div class="list-inline-item"><!-- Download SVG icon from http://tabler-icons.io/i/building-community -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M8 9l5 5v7h-5v-4m0 4h-5v-7l5 -5m1 1v-6a1 1 0 0 1 1 -1h10a1 1 0 0 1 1 1v17h-8"></path><path d="M13 7l0 .01"></path><path d="M17 7l0 .01"></path><path d="M17 11l0 .01"></path><path d="M17 15l0 .01"></path></svg>
                                    Spear AI</div>
                                  <div class="list-inline-item"><!-- Download SVG icon from http://tabler-icons.io/i/license -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M15 21h-9a3 3 0 0 1 -3 -3v-1h10v2a2 2 0 0 0 4 0v-14a2 2 0 1 1 2 2h-2m2 -4h-11a3 3 0 0 0 -3 3v11"></path><path d="M9 7l4 0"></path><path d="M9 11l4 0"></path></svg>
                                    Full-time</div>
                                  <div class="list-inline-item"><!-- Download SVG icon from http://tabler-icons.io/i/map-pin -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M12 11m-3 0a3 3 0 1 0 6 0a3 3 0 1 0 -6 0"></path><path d="M17.657 16.657l-4.243 4.243a2 2 0 0 1 -2.827 0l-4.244 -4.243a8 8 0 1 1 11.314 0z"></path></svg>
                                    Washington D.C.</div>
                                </div>
                                <div class="mt-3 list mb-0 text-muted d-block d-sm-none">
                                  <div class="list-item"><!-- Download SVG icon from http://tabler-icons.io/i/building-community -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M8 9l5 5v7h-5v-4m0 4h-5v-7l5 -5m1 1v-6a1 1 0 0 1 1 -1h10a1 1 0 0 1 1 1v17h-8"></path><path d="M13 7l0 .01"></path><path d="M17 7l0 .01"></path><path d="M17 11l0 .01"></path><path d="M17 15l0 .01"></path></svg>
                                    Spear AI</div>
                                  <div class="list-item"><!-- Download SVG icon from http://tabler-icons.io/i/license -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M15 21h-9a3 3 0 0 1 -3 -3v-1h10v2a2 2 0 0 0 4 0v-14a2 2 0 1 1 2 2h-2m2 -4h-11a3 3 0 0 0 -3 3v11"></path><path d="M9 7l4 0"></path><path d="M9 11l4 0"></path></svg>
                                    Full-time</div>
                                  <div class="list-item"><!-- Download SVG icon from http://tabler-icons.io/i/map-pin -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M12 11m-3 0a3 3 0 1 0 6 0a3 3 0 1 0 -6 0"></path><path d="M17.657 16.657l-4.243 4.243a2 2 0 0 1 -2.827 0l-4.244 -4.243a8 8 0 1 1 11.314 0z"></path></svg>
                                    Washington D.C.</div>
                                </div>
                              </div>
                              <div class="col-md-auto">
                                <div class="mt-3 badges">
                                  <a href="#" class="badge badge-outline text-muted border fw-normal badge-pill">HTML</a>
                                  <a href="#" class="badge badge-outline text-muted border fw-normal badge-pill">JavaScript</a>
                                  <a href="#" class="badge badge-outline text-muted border fw-normal badge-pill">CSS</a>
                                  <a href="#" class="badge badge-outline text-muted border fw-normal badge-pill">+3</a>
                                </div>
                              </div>
                            </div>
                          </div>
                        </div>
                      </div>
                    </div>
                    <div class="card">
                      <div class="row g-0">
                        <div class="col-auto">
                          <div class="card-body">
                            <div class="avatar avatar-md" style="background-image: url(src/assets/jobs/job-8.png)"></div>
                          </div>
                        </div>
                        <div class="col">
                          <div class="card-body ps-0">
                            <div class="row">
                              <div class="col">
                                <h3 class="mb-0"><a href="#">Web Developer</a></h3>
                              </div>
                            </div>
                            <div class="row">
                              <div class="col-md">
                                <div class="mt-3 list-inline list-inline-dots mb-0 text-muted d-sm-block d-none">
                                  <div class="list-inline-item"><!-- Download SVG icon from http://tabler-icons.io/i/building-community -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M8 9l5 5v7h-5v-4m0 4h-5v-7l5 -5m1 1v-6a1 1 0 0 1 1 -1h10a1 1 0 0 1 1 1v17h-8"></path><path d="M13 7l0 .01"></path><path d="M17 7l0 .01"></path><path d="M17 11l0 .01"></path><path d="M17 15l0 .01"></path></svg>
                                    Third Time Games</div>
                                  <div class="list-inline-item"><!-- Download SVG icon from http://tabler-icons.io/i/license -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M15 21h-9a3 3 0 0 1 -3 -3v-1h10v2a2 2 0 0 0 4 0v-14a2 2 0 1 1 2 2h-2m2 -4h-11a3 3 0 0 0 -3 3v11"></path><path d="M9 7l4 0"></path><path d="M9 11l4 0"></path></svg>
                                    Full-time</div>
                                  <div class="list-inline-item"><!-- Download SVG icon from http://tabler-icons.io/i/map-pin -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M12 11m-3 0a3 3 0 1 0 6 0a3 3 0 1 0 -6 0"></path><path d="M17.657 16.657l-4.243 4.243a2 2 0 0 1 -2.827 0l-4.244 -4.243a8 8 0 1 1 11.314 0z"></path></svg>
                                    Remote / North America</div>
                                </div>
                                <div class="mt-3 list mb-0 text-muted d-block d-sm-none">
                                  <div class="list-item"><!-- Download SVG icon from http://tabler-icons.io/i/building-community -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M8 9l5 5v7h-5v-4m0 4h-5v-7l5 -5m1 1v-6a1 1 0 0 1 1 -1h10a1 1 0 0 1 1 1v17h-8"></path><path d="M13 7l0 .01"></path><path d="M17 7l0 .01"></path><path d="M17 11l0 .01"></path><path d="M17 15l0 .01"></path></svg>
                                    Third Time Games</div>
                                  <div class="list-item"><!-- Download SVG icon from http://tabler-icons.io/i/license -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M15 21h-9a3 3 0 0 1 -3 -3v-1h10v2a2 2 0 0 0 4 0v-14a2 2 0 1 1 2 2h-2m2 -4h-11a3 3 0 0 0 -3 3v11"></path><path d="M9 7l4 0"></path><path d="M9 11l4 0"></path></svg>
                                    Full-time</div>
                                  <div class="list-item"><!-- Download SVG icon from http://tabler-icons.io/i/map-pin -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M12 11m-3 0a3 3 0 1 0 6 0a3 3 0 1 0 -6 0"></path><path d="M17.657 16.657l-4.243 4.243a2 2 0 0 1 -2.827 0l-4.244 -4.243a8 8 0 1 1 11.314 0z"></path></svg>
                                    Remote / North America</div>
                                </div>
                              </div>
                              <div class="col-md-auto">
                                <div class="mt-3 badges">
                                  <a href="#" class="badge badge-outline text-muted border fw-normal badge-pill">PHP</a>
                                  <a href="#" class="badge badge-outline text-muted border fw-normal badge-pill">Laravel</a>
                                  <a href="#" class="badge badge-outline text-muted border fw-normal badge-pill">React</a>
                                  <a href="#" class="badge badge-outline text-muted border fw-normal badge-pill">+8</a>
                                </div>
                              </div>
                            </div>
                          </div>
                        </div>
                      </div>
                    </div>
                    <div class="card">
                      <div class="row g-0">
                        <div class="col-auto">
                          <div class="card-body">
                            <div class="avatar avatar-md" style="background-image: url(src/assets/jobs/job-9.jpg)"></div>
                          </div>
                        </div>
                        <div class="col">
                          <div class="card-body ps-0">
                            <div class="row">
                              <div class="col">
                                <h3 class="mb-0"><a href="#">Laravel Developer</a></h3>
                              </div>
                            </div>
                            <div class="row">
                              <div class="col-md">
                                <div class="mt-3 list-inline list-inline-dots mb-0 text-muted d-sm-block d-none">
                                  <div class="list-inline-item"><!-- Download SVG icon from http://tabler-icons.io/i/building-community -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M8 9l5 5v7h-5v-4m0 4h-5v-7l5 -5m1 1v-6a1 1 0 0 1 1 -1h10a1 1 0 0 1 1 1v17h-8"></path><path d="M13 7l0 .01"></path><path d="M17 7l0 .01"></path><path d="M17 11l0 .01"></path><path d="M17 15l0 .01"></path></svg>
                                    Mindsize</div>
                                  <div class="list-inline-item"><!-- Download SVG icon from http://tabler-icons.io/i/license -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M15 21h-9a3 3 0 0 1 -3 -3v-1h10v2a2 2 0 0 0 4 0v-14a2 2 0 1 1 2 2h-2m2 -4h-11a3 3 0 0 0 -3 3v11"></path><path d="M9 7l4 0"></path><path d="M9 11l4 0"></path></svg>
                                    Full-time</div>
                                  <div class="list-inline-item"><!-- Download SVG icon from http://tabler-icons.io/i/map-pin -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M12 11m-3 0a3 3 0 1 0 6 0a3 3 0 1 0 -6 0"></path><path d="M17.657 16.657l-4.243 4.243a2 2 0 0 1 -2.827 0l-4.244 -4.243a8 8 0 1 1 11.314 0z"></path></svg>
                                    Remote / USA</div>
                                </div>
                                <div class="mt-3 list mb-0 text-muted d-block d-sm-none">
                                  <div class="list-item"><!-- Download SVG icon from http://tabler-icons.io/i/building-community -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M8 9l5 5v7h-5v-4m0 4h-5v-7l5 -5m1 1v-6a1 1 0 0 1 1 -1h10a1 1 0 0 1 1 1v17h-8"></path><path d="M13 7l0 .01"></path><path d="M17 7l0 .01"></path><path d="M17 11l0 .01"></path><path d="M17 15l0 .01"></path></svg>
                                    Mindsize</div>
                                  <div class="list-item"><!-- Download SVG icon from http://tabler-icons.io/i/license -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M15 21h-9a3 3 0 0 1 -3 -3v-1h10v2a2 2 0 0 0 4 0v-14a2 2 0 1 1 2 2h-2m2 -4h-11a3 3 0 0 0 -3 3v11"></path><path d="M9 7l4 0"></path><path d="M9 11l4 0"></path></svg>
                                    Full-time</div>
                                  <div class="list-item"><!-- Download SVG icon from http://tabler-icons.io/i/map-pin -->
                                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-inline" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M12 11m-3 0a3 3 0 1 0 6 0a3 3 0 1 0 -6 0"></path><path d="M17.657 16.657l-4.243 4.243a2 2 0 0 1 -2.827 0l-4.244 -4.243a8 8 0 1 1 11.314 0z"></path></svg>
                                    Remote / USA</div>
                                </div>
                              </div>
                              <div class="col-md-auto">
                                <div class="mt-3 badges">
                                  <a href="#" class="badge badge-outline text-muted border fw-normal badge-pill">PHP</a>
                                  <a href="#" class="badge badge-outline text-muted border fw-normal badge-pill">Laravel</a>
                                </div>
                              </div>
                            </div>
                          </div>
                        </div>
                      </div>
                    </div>
                  </div>
                </div>
                </div>
                <div class="col-md-6 col-lg-4">
                  <div class="row row-cards">
                      <div class="col-12">
                        <div class="card card-sm">
                          <div class="card-body">
                            <div class="row align-items-center">
                              <div class="col-auto">
                                <span class="bg-red text-white avatar"><!-- Download SVG icon from http://tabler-icons.io/i/user -->
                                  <svg xmlns="http://www.w3.org/2000/svg" class="icon" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M12 7m-4 0a4 4 0 1 0 8 0a4 4 0 1 0 -8 0"></path><path d="M6 21v-2a4 4 0 0 1 4 -4h4a4 4 0 0 1 4 4v2"></path></svg>
                                </span>
                              </div>
                              <div class="col">
                                <div class="font-weight-medium">
                                  1352 Members
                                </div>
                                <div class="text-muted">
                                  163 registered today
                                </div>
                              </div>
                            </div>
                          </div>
                        </div>
                      </div>
                      <div class="col-12">
                        <div class="card">
                          <div class="card-header">
                            <h3 class="card-title">Card with code</h3>
                          </div>
                          <div class="card-code">
                            <figure class="highlight">
                              <pre><code class="language-scss" data-lang="scss"><span class="nc">.card-footer</span> <span class="p">{</span>
      <span class="nl">background</span><span class="p">:</span> <span class="nb">transparent</span><span class="p">;</span>

      <span class="k">&amp;</span><span class="nd">:last-child</span> <span class="p">{</span>
        <span class="nl">border-radius</span><span class="p">:</span> <span class="m">0</span> <span class="m">0</span> <span class="m">1</span> <span class="m">2</span><span class="p">;</span>
      <span class="p">}</span>
    <span class="p">}</span></code></pre>
                            </figure>
                          </div>
                        </div>
                      </div>
                      <div class="col-12">
                    <div class="card">
                      <div class="card-body">
                        <div class="card-title">Basic info</div>
                        <div class="mb-2">
                          <!-- Download SVG icon from http://tabler-icons.io/i/book -->
                          <svg xmlns="http://www.w3.org/2000/svg" class="icon me-2 text-muted" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M3 19a9 9 0 0 1 9 0a9 9 0 0 1 9 0"></path><path d="M3 6a9 9 0 0 1 9 0a9 9 0 0 1 9 0"></path><path d="M3 6l0 13"></path><path d="M12 6l0 13"></path><path d="M21 6l0 13"></path></svg>
                          Went to: <strong>University of Ljubljana</strong>
                        </div>
                        <div class="mb-2">
                          <!-- Download SVG icon from http://tabler-icons.io/i/briefcase -->
                          <svg xmlns="http://www.w3.org/2000/svg" class="icon me-2 text-muted" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M3 7m0 2a2 2 0 0 1 2 -2h14a2 2 0 0 1 2 2v9a2 2 0 0 1 -2 2h-14a2 2 0 0 1 -2 -2z"></path><path d="M8 7v-2a2 2 0 0 1 2 -2h4a2 2 0 0 1 2 2v2"></path><path d="M12 12l0 .01"></path><path d="M3 13a20 20 0 0 0 18 0"></path></svg>
                          Worked at: <strong>Devpulse</strong>
                        </div>
                        <div class="mb-2">
                          <!-- Download SVG icon from http://tabler-icons.io/i/home -->
                          <svg xmlns="http://www.w3.org/2000/svg" class="icon me-2 text-muted" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M5 12l-2 0l9 -9l9 9l-2 0"></path><path d="M5 12v7a2 2 0 0 0 2 2h10a2 2 0 0 0 2 -2v-7"></path><path d="M9 21v-6a2 2 0 0 1 2 -2h2a2 2 0 0 1 2 2v6"></path></svg>
                          Lives in: <strong>Šentilj v Slov. Goricah, Slovenia</strong>
                        </div>
                        <div class="mb-2">
                          <!-- Download SVG icon from http://tabler-icons.io/i/map-pin -->
                          <svg xmlns="http://www.w3.org/2000/svg" class="icon me-2 text-muted" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M12 11m-3 0a3 3 0 1 0 6 0a3 3 0 1 0 -6 0"></path><path d="M17.657 16.657l-4.243 4.243a2 2 0 0 1 -2.827 0l-4.244 -4.243a8 8 0 1 1 11.314 0z"></path></svg>
                          From: <strong><span class="flag flag-country-si"></span>
                            Slovenia</strong>
                        </div>
                        <div class="mb-2">
                          <!-- Download SVG icon from http://tabler-icons.io/i/calendar -->
                          <svg xmlns="http://www.w3.org/2000/svg" class="icon me-2 text-muted" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M4 5m0 2a2 2 0 0 1 2 -2h12a2 2 0 0 1 2 2v12a2 2 0 0 1 -2 2h-12a2 2 0 0 1 -2 -2z"></path><path d="M16 3l0 4"></path><path d="M8 3l0 4"></path><path d="M4 11l16 0"></path><path d="M11 15l1 0"></path><path d="M12 15l0 3"></path></svg>
                          Birth date: <strong>13/01/1985</strong>
                        </div>
                        <div>
                          <!-- Download SVG icon from http://tabler-icons.io/i/clock -->
                          <svg xmlns="http://www.w3.org/2000/svg" class="icon me-2 text-muted" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"></path><path d="M12 12m-9 0a9 9 0 1 0 18 0a9 9 0 1 0 -18 0"></path><path d="M12 7l0 5l3 3"></path></svg>
                          Time zone: <strong>Europe/Ljubljana</strong>
                        </div>
                      </div>
                    </div>
                  </div>
                  </div>
                </div>
            </div>
        </div>
    </div>

</template>

<style scoped lang="scss">
</style>