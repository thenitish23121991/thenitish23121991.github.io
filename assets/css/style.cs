* {
  margin: 0px;
  padding: 0px; }

html, body {
  height: 100%;
  width: 100%;
  overflow-x: hidden; }

@font-face {
  src: url("../fonts/Graphik-Regular.ttf");
  font-family: 'GraphikRegular'; }
@font-face {
  src: url("../fonts/Graphik-Medium.ttf");
  font-family: 'GraphikMedium'; }
@font-face {
  src: url("../fonts/FreightText-Book.ttf");
  font-family: 'FreightTextBook'; }
@font-face {
  src: url("../fonts/NeuzeitStdBook.otf");
  font-family: 'NeuzeitRegular'; }
@font-face {
  src: url("../fonts/basis-grotesque-regular.ttf");
  font-family: 'BasisGrotesqueRegular'; }
@font-face {
  src: url("../fonts/basis-grotesque-medium.ttf");
  font-family: 'BasisGrotesqueMedium'; }
@font-face {
  src: url("../fonts/basis-grotesque-bold.ttf");
  font-family: 'BasisGrotesqueBold'; }
@font-face {
  src: url("../fonts/FavoritStd-Regular.woff");
  font-family: 'FavoritRegular'; }
@font-face {
  src: url("../fonts/Mier-Book.ttf");
  font-family: 'MierRegular'; }
body {
  transform-origin: center;
  -webkit-transform-origin: center;
  -moz-transform-origin: center;
  -ms-transform-origin: center;
  -o-transform-origin: center; }

a {
  position: relative;
  color: #1111ee;
  text-decoration: none;
  padding-top: -32px;
  overflow: hidden; }

#footer a {
  color: #9199de; }

a.primary_color {
  color: #123FEC; }

a::after {
  position: absolute;
  width: 0%;
  height: 1px;
  background: #9199de;
  content: '';
  top: 104%;
  left: 0%;
  transition: all cubic-bezier(0.31, 1.02, 0.84, 0.99) 0.45s; }

.link_container {
  display: inline-block;
  padding: 16px 0px; }

.tab {
  text-decoration: none; }

.text_link {
  padding-bottom: 4px;
  border-bottom: 2px solid black; }

.link_seperator {
  display: inline-block;
  margin: 0px 8px;
  background-color: linear-gradient(to right, #123FEC, #328FFF);
  height: 20px;
  width: 2px;
  transform: rotateY(-25deg);
  -moz-transform: rotateY(-25deg);
  -webkit-transform: rotateY(-25deg);
  -ms-transform: rotateY(-25deg);
  -o-transform: rotateY(-25deg); }

.clear {
  clear: both; }

body {
  font-smoothing: antialised;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  overflow-x: hidden; }

.container {
  position: relative;
  min-height: 100%;
  width: 100%; }

[data-scroll], [data-scroll-content] {
  min-height: 100vh;
  width: 100%;
  will-change: transform; }

#top_left_container {
  position: absolute;
  top: -.7%;
  left: 0px;
  height: 100%; }

#top_right_container {
  position: absolute;
  top: -0.7%;
  right: 0px;
  height: 100%; }

.top_container {
  position: relative;
  width: 100vw;
  height: 90vh;
  z-index: 20; }

.header_new_container {
  position: relative;
  width: 100vw;
  padding: 20px 0px; }

.header_new_container.scrolled {
  background: #fff;
  position: fixed;
  will-change: transform;
  border-bottom: 1px solid #eaeaea; }

.header_new_container {
  position: fixed;
  top: 0px;
  left: 0px;
  min-height: 40px;
  width: 100vw;
  z-index: 300;
  will-change: transform;
  transition: all 0.4s cubic-bezier(0.31, 1.02, 0.84, 0.99) 0s;
  -webkit-transition: all 0.4s cubic-bezier(0.31, 1.02, 0.84, 0.99) 0s;
  -moz-transition: all 0.4s cubic-bezier(0.31, 1.02, 0.84, 0.99) 0s;
  -ms-transition: all 0.4s cubic-bezier(0.31, 1.02, 0.84, 0.99) 0s;
  -o-transition: all 0.4s cubic-bezier(0.31, 1.02, 0.84, 0.99) 0s; }

.header_new_container.header_fixed {
  box-shadow: 0px 2px 4px 1px rgba(0, 0, 0, 0.12);
  -webkit-box-shadow: 0px 2px 4px 1px rgba(0, 0, 0, 0.12);
  -moz-box-shadow: 0px 2px 4px 1px rgba(0, 0, 0, 0.12);
  -ms-box-shadow: 0px 2px 4px 1px rgba(0, 0, 0, 0.12);
  -o-box-shadow: 0px 2px 4px 1px rgba(0, 0, 0, 0.12);
  transition: all 0.4s cubic-bezier(0.31, 1.02, 0.84, 0.99) 0s;
  -webkit-transition: all 0.4s cubic-bezier(0.31, 1.02, 0.84, 0.99) 0s;
  -moz-transition: all 0.4s cubic-bezier(0.31, 1.02, 0.84, 0.99) 0s;
  -ms-transition: all 0.4s cubic-bezier(0.31, 1.02, 0.84, 0.99) 0s;
  -o-transition: all 0.4s cubic-bezier(0.31, 1.02, 0.84, 0.99) 0s; }

.header_menu_list_item {
  transform: translateY(0px);
  -webkit-transform: translateY(0px);
  -moz-transform: translateY(0px);
  -ms-transform: translateY(0px);
  -o-transform: translateY(0px);
  transition: all 0.4s cubic-bezier(0.31, 1.02, 0.84, 0.99);
  -webkit-transition: all 0.4s cubic-bezier(0.31, 1.02, 0.84, 0.99);
  -moz-transition: all 0.4s cubic-bezier(0.31, 1.02, 0.84, 0.99);
  -ms-transition: all 0.4s cubic-bezier(0.31, 1.02, 0.84, 0.99);
  -o-transition: all 0.4s cubic-bezier(0.31, 1.02, 0.84, 0.99); }

.header_new_container.hide .header_menu_list_item {
  opacity: 0;
  transform: translateY(20px);
  -webkit-transform: translateY(20px);
  -moz-transform: translateY(20px);
  -ms-transform: translateY(20px);
  -o-transform: translateY(20px); }

.header_background {
  position: absolute;
  top: 0px;
  left: 0px;
  width: 100vw;
  height: 0vh;
  background: #fff;
  z-index: 50;
  transition: all  .3s ease-out 0s;
  -webkit-transition: all  .3s ease-out 0s;
  -moz-transition: all  .3s ease-out 0s;
  -ms-transition: all  .3s ease-out 0s;
  -o-transition: all  .3s ease-out 0s; }

#about_container .header_background {
  background: #222; }

.header_top ul {
  min-height: 48px;
  display: inline-block;
  text-align: center; }

.header_list_item {
  float: left;
  margin-left: 60px;
  list-style-type: none;
  font-family: "BasisGrotesqueRegular";
  font-size: 17px;
  transform: translateY(0px);
  -webkit-transform: translateY(0px);
  -moz-transform: translateY(0px);
  -ms-transform: translateY(0px);
  -o-transform: translateY(0px);
  transition: all 0.4s cubic-bezier(0.52, 1.18, 0.87, 1.03);
  -webkit-transition: all 0.4s cubic-bezier(0.52, 1.18, 0.87, 1.03);
  -moz-transition: all 0.4s cubic-bezier(0.52, 1.18, 0.87, 1.03);
  -ms-transition: all 0.4s cubic-bezier(0.52, 1.18, 0.87, 1.03);
  -o-transition: all 0.4s cubic-bezier(0.52, 1.18, 0.87, 1.03); }

.header_menu_list_item:nth-child(1) {
  transition-delay: .1s;
  -webkit-transition-delay: .05s;
  -moz-transition-delay: .05s;
  -ms-transition-delay: .05s;
  -o-transition-delay: .05s; }

.header_menu_list_item:nth-child(2) {
  transition-delay: .1s;
  -webkit-transition-delay: .1s;
  -moz-transition-delay: .1s;
  -ms-transition-delay: .1s;
  -o-transition-delay: .1s; }

.header_menu_list_item:nth-child(3) {
  transition-delay: .15s;
  -webkit-transition-delay: .15s;
  -moz-transition-delay: .15s;
  -ms-transition-delay: .15s;
  -o-transition-delay: .15s; }

.header_menu_list_item:nth-child(4) {
  transition-delay: .2s;
  -webkit-transition-delay: .2s;
  -moz-transition-delay: .2s;
  -ms-transition-delay: .2s;
  -o-transition-delay: .2s; }

.header_menu_list_item:nth-child(5) {
  transition-delay: .25s;
  -webkit-transition-delay: .25s;
  -moz-transition-delay: .25s;
  -ms-transition-delay: .25s;
  -o-transition-delay: .25s; }

.header_list_item#logo_list_item a {
  padding: 0px 36px;
  padding-top: 12px; }

li.clear {
  list-style-type: none; }

.header_menu_container_new.header_fixed .header_menu_list_item {
  color: rgba(0, 0, 0, 0.87); }

.header_new_container a:hover {
  transform: translateY(25px);
  -webkit-transform: translateY(25px);
  -moz-transform: translateY(25px);
  -ms-transform: translateY(25px);
  -o-transform: translateY(25px); }

a:hover::after {
  width: 100%;
  transition: width .3s; }

.header_list_item a {
  position: relative;
  padding-bottom: 4px; }

.header_list_item a:after {
  position: absolute;
  height: 2px;
  width: 0%;
  top: 108%;
  left: 0%;
  content: '';
  background: linear-gradient(to right, #123FEC, #328FFF);
  transition: all 0.3s cubic-bezier(0.52, 1.18, 0.87, 1.03) 0s;
  -webkit-transition: all 0.3s cubic-bezier(0.52, 1.18, 0.87, 1.03) 0s;
  -moz-transition: all 0.3s cubic-bezier(0.52, 1.18, 0.87, 1.03) 0s;
  -ms-transition: all 0.3s cubic-bezier(0.52, 1.18, 0.87, 1.03) 0s;
  -o-transition: all 0.3s cubic-bezier(0.52, 1.18, 0.87, 1.03) 0s; }

#logo_list_item a:hover::after {
  width: 0%; }

.header_menu_list_item.selected {
  font-family: "BasisGrotesqueMedium"; }

.header_list_item:nth-child(1) {
  margin-left: 0px; }

.header_list_item:not(#logo_list_item) {
  padding-top: 8px; }

.header_list_item a {
  color: rgba(0, 0, 0, 0.87);
  text-transform: uppercase; }

.header_text {
  margin-top: 72px;
  width: 76%;
  padding: 88px 10% 0px 196px;
  font-family: "BasisGrotesqueRegular";
  font-size: 31.5px;
  line-height: 48px; }

.header_text_2 {
  margin-top: 20px; }

.header_text_2 a {
  color: #3600B3;
  position: relative;
  overflow: hidden; }

.header_text_desc {
  font-family: "BasisGrotesqueRegular";
  font-size: 24px;
  color: rgba(0, 0, 0, 0.87);
  line-height: 52px;
  width: 84%;
  margin-top: 16px; }

.past_experiences_container {
  font-family: "BasisGrotesqueRegular";
  font-size: 20px;
  line-height: 32px;
  margin-top: 20px; }

.experiments_container {
  padding: 0px 8vw; }

.selected_works_container {
  padding: 0px 6vw; }

.heading {
  font-family: "BasisGrotesqueRegular";
  font-size: 31px;
  line-height: 48px; }

.heading_desc {
  font-family: "BasisGrotesqueRegular";
  font-size: 24px;
  line-height: 48px;
  color: rgba(0, 0, 0, 0.5); }

.selected_works_line {
  display: none;
  height: 4px;
  width: 96px;
  background: linear-gradient(to right, #123FEC, #328FFF);
  margin: 20px 0px 16px 0px; }

.selected_works_content {
  padding: 24px 0px; }

.work_container {
  position: relative;
  width: 84vw;
  border-radius: 4px;
  overflow: hidden;
  margin-top: 64px;
  overflow: hidden;
  z-index: 50;
  height: 488px;
  width: 0%;
  transition: transform .7s ease 0s, width .7s ease .3s;
  -webkit-transition: transform .7s ease 0s, width .7s ease .3s;
  -moz-transition: transform .7s ease 0, width .7s ease .3s;
  -ms-transition: transform .7s ease 0s, width .7s ease .3s;
  -o-transition: transform .7s ease 0s, width .7s ease .3s; }

.work_container.show {
  width: 100%; }

.work_container:nth-child(1) {
  margin-top: 0px; }

#pvr_cinemas_app_container {
  background: #FDD362; }

#pvr_cinemas_container {
  background: #333344; }

#feetapart_container {
  background: #739E56; }

#feetapart_container .case_study_button {
  background: #497429; }

#stanza_container {
  background: #009782; }

#litewallet_container {
  background: #5c0dC5; }

#crosschecks_container {
  background: #315943; }

#studycopter_container {
  background: #474678; }

#goqii_container {
  background: #2F67FF; }

#murals_container {
  background: #2f2f33; }

#murals_container .work_desc_cover_container {
  background-image: url("../images/mural_background.png");
  background-size: cover; }

#crosschecks_container .work_desc_num {
  color: rgba(0, 0, 0, 0.6); }

.work_container.white_text .work_desc_title {
  color: white; }

.work_container.white_text .work_desc_num {
  color: rgba(255, 255, 255, 0.7); }

.work_container.dark_text .work_desc_date {
  color: rgba(0, 0, 0, 0.87); }

#litewallet_container .work_cover_container img {
  margin-top: 0%;
  margin-left: -1%; }

.work_cover_container {
  position: absolute;
  left: 37%;
  top: -2%;
  width: 140%;
  opacity: 0;
  transition: all 0.8s cubic-bezier(0.19, 1, 0.22, 1) 0.8s;
  -webkit-transition: all 0.8s cubic-bezier(0.19, 1, 0.22, 1) 0.8s;
  -moz-transition: all 0.8s cubic-bezier(0.19, 1, 0.22, 1) 0.8s;
  -ms-transition: all 0.8s cubic-bezier(0.19, 1, 0.22, 1) 0.8s;
  -o-transition: all 0.8s cubic-bezier(0.19, 1, 0.22, 1) 0.8s;
  transform: translateY(70px);
  -webkit-transform: translateY(70px);
  -moz-transform: translateY(70px);
  -ms-transform: translateY(70px);
  -o-transform: translateY(70px); }

#goqii_container .work_cover_container {
  left: 22%;
  top: 0%; }

#stanza_container .work_cover_container {
  top: 2%;
  left: 43%; }

.work_cover_container img {
  margin-left: -80px; }

.work_cover_container img:nth-child(1) {
  margin-left: 0px; }

.work_desc_container {
  width: 420px;
  position: absolute;
  top: 17%;
  margin: 0px 32px; }

.work_desc_cover_container {
  position: absolute;
  height: 480px;
  width: 66%;
  left: 34%;
  bottom: 0%; }

.work_desc_num {
  color: rgba(0, 0, 0, 0.32);
  font-family: 'BasisGrotesqueBold';
  font-size: 42px;
  opacity: 0;
  transform: translateX(0px);
  -webkit-transform: translateX(0px);
  -moz-transform: translateX(0px);
  -ms-transform: translateX(0px);
  -o-transform: translateX(0px);
  transition: all .4s ease-in 0s;
  -webkit-transition: all .4s ease-in 0s;
  -moz-transition: all .4s ease-in 0s;
  -ms-transition: all .4s ease-in 0s;
  -o-transition: all .4s ease-in 0s; }

#pvr_cinemas_container .work_desc_num, #murals_container .work_desc_num {
  color: rgba(255, 255, 255, 0.7); }

#litewallet_container .work_desc_num {
  color: rgba(255, 255, 255, 0.4); }

.work_desc_title {
  font-family: "BasisGrotesqueRegular";
  font-size: 25px;
  line-height: 48px;
  margin-top: 8px;
  color: rgba(0, 0, 0, 0.87); }

.work_desc_date {
  font-family: "BasisGrotesqueRegular";
  font-size: 17px;
  margin-top: 4px;
  color: white;
  opacity: 0;
  transform: translateX(-15px);
  -webkit-transform: translateX(-15px);
  -moz-transform: translateX(-15px);
  -ms-transform: translateX(-15px);
  -o-transform: translateX(-15px); }

#murals_container .work_desc_title .work_desc_inner {
  display: inline-block;
  padding: 4px 24px;
  background: #474747; }

.work_container .work_desc_title .work_desc_inner:nth-child(1), .work_container .work_desc_title .work_desc_inner:nth-child(3) {
  padding: 4px 24px; }

.dark_container .work_desc_title {
  color: #fff; }

.dark_container .work_desc_date {
  color: rgba(255, 255, 255, 0.7); }

#studycopter_container .work_desc_date {
  color: rgba(255, 255, 255, 0.7); }

.work_container a {
  position: absolute;
  top: 0px;
  left: 0px;
  height: 100%;
  width: 100%; }

.footer {
  background: #f9f9f9;
  margin-top: 40px;
  padding: 40px 88px 32px 120px;
  min-height: 96px; }

.footer_text_1 {
  font-family: "BasisGrotesqueRegular";
  font-size: 31px;
  line-height: 48px; }

.footer_text_2, .footer_text_3 {
  font-family: "BasisGrotesqueRegular";
  font-size: 20px;
  line-height: 40px;
  margin-top: 8px; }

.footer_text_3 {
  margin-top: 12px; }

.personal_links_container {
  margin: 36px 0% 16px 0%;
  font-size: 20px;
  line-height: 40px;
  width: 80%; }

.link_single_container {
  display: inline-block;
  margin-left: 8px; }

.link_single_container:nth-child(1) {
  margin-left: 0px; }

.seperator {
  margin-left: 4px;
  margin-top: -8px;
  display: inline-block;
  vertical-align: 2px;
  font-size: 17px; }

#about_container.container {
  background: #121212;
  min-height: 100%;
  color: #fff;
  width: 100vw; }

.about_body_container {
  min-height: 240px;
  width: 100%; }

.about_top_container {
  padding-top: 21vh;
  width: 100%; }

.about_head_container {
  color: white;
  font-family: "BasisGrotesqueMedium";
  font-size: 27.65px;
  line-height: 52px;
  float: left;
  padding-left: 10vw;
  width: 44vw; }

.about_pic_container {
  float: left;
  margin-left: 4vw;
  margin-top: -4vh; }

#about_container .header_list_item a {
  color: #fff; }

.design_principles_container, .about_section_container {
  margin-top: 56px; }

.title_2 {
  font-family: "BasisGrotesqueMedium";
  font-size: 24px; }

.body_2 {
  font-family: 'FreightTextBook';
  font-size: 22px;
  line-height: 40px;
  margin-top: 20px;
  color: rgba(255, 255, 255, 0.9); }

.quote_outer_container {
  margin: 16px 0px; }

.quote_container {
  display: inline-block;
  border-left: 4px solid #2143ff;
  padding: 16px 28px;
  overflow: hidden;
  background: #2a2a2a;
  margin-top: 8px; }

.quote_text {
  font-family: "BasisGrotesqueRegular";
  font-size: 24px;
  line-height: 36px; }

.quote_author {
  font-family: "BasisGrotesqueRegular";
  font-size: 20px;
  margin-top: 12px;
  margin-bottom: 4px; }

.experiments_container {
  margin-top: 56px; }

.personal_links_container a span.icon img {
  display: inline-block;
  height: 20px;
  width: 20px; }

.personal_links_container a.behance span.icon img {
  height: 22px;
  width: 22px;
  margin-top: 8px; }

.personal_links_container a span.icon {
  margin-right: 4px; }

.personal_links_container a.linkedin {
  color: #2867B2; }

.personal_links_container a.behance {
  color: #053DFF; }

.personal_links_container a.github {
  color: #1066D6; }

.personal_links_container a.medium {
  color: #00ab6c; }

.personal_links_container a.pinterest {
  color: #bd081c; }

.personal_links_container a.linkedin::after {
  background: #2867B2; }

.personal_links_container a.medium::after {
  background: #00ab6c; }

.personal_links_container a.behance::after {
  background: #053DFF; }

.personal_links_container a.github::after {
  background: #1066D6; }

.personal_links_container a.pinterest::after {
  background: #bd081c; }

a.pvr_cinemas {
  color: #111122; }

a.studycopter {
  color: #30D934; }

a.amituslab {
  color: #dd1344; }

a.pvr_cinemas::after {
  background: #111122; }

a.studycopter::after {
  background: #30D934; }

a.amituslab::after {
  background: #dd1344; }

.social_link_text:nth-child(1) {
  margin-left: 0px; }

.social_link_seperator {
  font-family: "BasisGrotesqueMedium"; }

.social_link_icon img {
  height: 12px;
  width: 12px; }

.linkedin .social_link_icon svg g {
  fill: #2867B2; }

.medium .social_link_icon svg g {
  fill: #00ab6c; }

.behance .social_link_icon svg g {
  fill: #053DFF; }

.github .social_link_icon svg g {
  fill: #1066D6; }

.pinterest .social_link_icon svg g {
  fill: #bd081c; }

.personal_links_container a.linkedin {
  margin-left: 4px; }

.personal_links_container a {
  margin-left: 16px; }

.personal_links_container a:nth-child(1) {
  margin-left: 0px; }

.copyright {
  width: 100%;
  text-align: center;
  font-family: "BasisGrotesqueMedium";
  font-size: 16px;
  color: rgba(0, 0, 0, 0.87);
  margin-top: 24px; }

#top_right_bottom {
  position: absolute;
  top: 3.5%;
  right: 0%;
  height: 100%; }

.fixed {
  position: fixed;
  top: 0px;
  left: 0px;
  will-change: transform; }

.design_mark {
  padding: 16px 15%;
  font-family: "BasisGrotesqueMedium";
  font-size: 20px;
  line-height: 36px;
  width: 70%;
  text-align: center; }

#top_left_container svg g rect.whizzed {
  transition: all 1.2s cubic-bezier(0.52, 1.18, 0.87, 1.03) 0s, opacity 1.6s cubic-bezier(0.52, 1.18, 0.87, 1.03) 0s;
  -webkit-transition: all 1.2s cubic-bezier(0.52, 1.18, 0.87, 1.03) 0s, opacity 1.6s cubic-bezier(0.52, 1.18, 0.87, 1.03) 0s;
  -moz-transition: all 1.2s cubic-bezier(0.52, 1.18, 0.87, 1.03) 0s, opacity 1.6s cubic-bezier(0.52, 1.18, 0.87, 1.03) 0s;
  -o-transition: all 1.2s cubic-bezier(0.52, 1.18, 0.87, 1.03) 0s, opacity 1.6s cubic-bezier(0.52, 1.18, 0.87, 1.03) 0s;
  -ms-transition: all 1.2s cubic-bezier(0.52, 1.18, 0.87, 1.03) 0s, opacity 1.6s cubic-bezier(0.52, 1.18, 0.87, 1.03) 0s; }

.copy_vertical_inner {
  font-family: "BasisGrotesqueMedium"; }

svg g#Graphik g.animated rect {
  opacity: 0;
  width: 0px;
  transform: translateX(-200px);
  -webkit-transform: translateX(-200px);
  -moz-transform: translateX(-200px);
  -ms-transform: translateX(-200px);
  -o-transform: translateX(-200px); }

.pattern_left svg.no_width g#Experiments g#Homepage g#Group-22 g g polygon {
  transform: translateX(-190px) translateY(-190px);
  -webkit-transform: translateX(-190px) translateY(-190px); }

#footer {
  padding-bottom: 24px;
  padding-top: 48px;
  padding-left: 8vw; }

#footer.white_background {
  background: linear-gradient(to bottom right, #F6F6F6, #FCFCFC); }

#footer.dark_background {
  background: linear-gradient(to bottom right, #2a2a2a, #333339); }

.footer_title {
  font-family: "BasisGrotesqueRegular";
  font-size: 33.18px;
  line-height: 56px; }

.footer_title_2 {
  margin-top: 16px;
  font-family: "BasisGrotesqueRegular";
  font-size: 23.04px;
  line-height: 40px; }

.copyright {
  margin-top: 64px;
  font-size: 16px;
  line-height: 24px; }

.about_highlights_container {
  margin-top: 36px;
  width: 80vw; }

.highlight {
  float: left;
  width: 32vw;
  margin-left: 6vw;
  background: #28282e;
  margin-top: -16px;
  padding: 0px 16px;
  padding-top: 12px; }

.highlight:nth-child(1) {
  margin-top: 0px; }

.highlight:nth-child(2n) {
  margin-top: 40px; }

.highlight:nth-child(2) {
  margin-top: 56px; }

.highlight:nth-child(2n+1) {
  margin-left: 0px; }

.about_content_container {
  padding-bottom: 4vh; }

#about_container .footer {
  background: linear-gradient(to bottom right, #2a2a2a, #333339); }

#about_container .footer .copyright {
  color: white; }

.highlight_body {
  font-family: "BasisGrotesqueRegular";
  font-size: 23.04px;
  line-height: 40px;
  color: white; }

.highlight_time {
  font-family: "BasisGrotesqueRegular";
  font-size: 16px;
  line-height: 24px;
  color: rgba(255, 255, 255, 0.7);
  padding-bottom: 8px;
  padding-top: 8px; }

#about_container .quote_container {
  margin-left: 0px;
  margin-top: 32px;
  margin-bottom: 12px; }

#logo_list_item a img {
  transition: all 0.2s cubic-bezier(0.52, 1.18, 0.87, 1.03);
  -moz-transition: all 0.2s cubic-bezier(0.52, 1.18, 0.87, 1.03);
  -webkit-transition: all 0.2s cubic-bezier(0.52, 1.18, 0.87, 1.03);
  -ms-transition: all 0.2s cubic-bezier(0.52, 1.18, 0.87, 1.03);
  -o-transition: all 0.2s cubic-bezier(0.52, 1.18, 0.87, 1.03); }

#home_container .footer {
  padding-bottom: 32px; }

.scroll_container {
  position: absolute;
  bottom: 4%;
  left: 0%;
  width: 100%;
  text-align: center;
  margin-top: 8vh; }

.scroll_container_text {
  font-family: "BasisGrotesqueRegular";
  font-size: 13.3px;
  color: rgba(0, 0, 0, 0.64);
  width: 100%;
  text-align: center; }

.scroll_container img {
  height: 36px;
  width: 36px; }

#pvr_cinemas_app_container .work_cover_container img:nth-child(1) {
  margin-top: -4%; }

.work_container#feetapart_container .work_cover_container {
  top: 0%;
  height: 100%; }

.hidden {
  opacity: 0; }

.intro_container {
  position: absolute;
  top: 38%;
  left: 20%;
  width: 60%;
  text-align: center; }

.intro_name {
  font-family: "BasisGrotesqueMedium";
  font-size: 39.81px; }

.intro_desc {
  font-family: "BasisGrotesqueRegular";
  font-size: 23.04px; }

.intro_city {
  font-family: "BasisGrotesqueRegular";
  font-size: 23.04px; }

.anim_container {
  display: inline-block;
  overflow: hidden;
  width: 100%;
  height: auto;
  line-height: 52px; }

.anim_item {
  display: inline-block;
  transition: all 1s cubic-bezier(0.52, 1.18, 0.87, 1.03) 0s;
  -webkit-transition: all 1s cubic-bezier(0.52, 1.18, 0.87, 1.03) 0s;
  -ms-transition: all 1s cubic-bezier(0.52, 1.18, 0.87, 1.03) 0s;
  -ms-transition: all 1s cubic-bezier(0.52, 1.18, 0.87, 1.03) 0s;
  -o-transition: all 1s cubic-bezier(0.52, 1.18, 0.87, 1.03) 0s; }

.anim_item.hidden.down {
  opacity: 0;
  transform: translateY(30px);
  -webkit-transform: translateY(30px);
  -moz-transform: translateY(30px);
  -ms-transform: translateY(30px);
  -o-transform: translateY(30px); }

.anim_item.hidden.down.go_up {
  opacity: 1;
  transform: translateY(0px);
  -webkit-transform: translateY(0px);
  -moz-transform: translateY(0px);
  -ms-transform: translateY(0px);
  -o-transform: translateY(0px); }

.anim_item:nth-of-type(2) {
  transition-delay: .07s;
  -webkit-transition-delay: .07s;
  -moz-transition-delay: .07s;
  -ms-transition-delay: .07s;
  -o-transition-delay: .07s; }

.anim_item:nth-of-type(3) {
  transition-delay: .14s;
  -webkit-transition-delay: .14s;
  -moz-transition-delay: .14s;
  -ms-transition-delay: .14s;
  -o-transition-delay: .14s; }

.anim_item:nth-of-type(4) {
  transition-delay: .21s;
  -webkit-transition-delay: .21s;
  -moz-transition-delay: .21s;
  -ms-transition-delay: .21s;
  -o-transition-delay: .21s; }

.intro_desc .anim_item:nth-of-type(1) {
  transition-delay: .13s;
  -webkit-transition-delay: .13s;
  -moz-transition-delay: .13s;
  -ms-transition-delay: .13s;
  -o-transition-delay: .13s; }

.intro_desc .anim_item:nth-of-type(2) {
  transition-delay: .2s;
  -webkit-transition-delay: .2s;
  -moz-transition-delay: .2s;
  -ms-transition-delay: .2s;
  -o-transition-delay: .2s; }

.intro_desc .anim_item:nth-of-type(3) {
  transition-delay: .27s;
  -webkit-transition-delay: .27s;
  -moz-transition-delay: .27s;
  -ms-transition-delay: .27s;
  -o-transition-delay: .27s; }

.anim_item.hidden.go_up.up_class {
  transition: all 0.9s cubic-bezier(0.52, 1.18, 0.87, 1.03) 0s;
  -webkit-transition: all 0.9s cubic-bezier(0.52, 1.18, 0.87, 1.03) 0s;
  -ms-transition: all 0.9s cubic-bezier(0.52, 1.18, 0.87, 1.03) 0s;
  -ms-transition: all 0.9s cubic-bezier(0.52, 1.18, 0.87, 1.03) 0s;
  -o-transition: all 0.9s cubic-bezier(0.52, 1.18, 0.87, 1.03) 0s; }

.anim_item.hidden.go_up.hide {
  opacity: 0; }

.go_up_and_hide {
  opacity: 0;
  transform: translateY(-80px);
  -webkit-transform: translateY(-80px);
  -moz-transform: translateY(-80px);
  -ms-transform: translateY(-80px);
  -o-transform: translateY(-80px); }

.go_down_and_hide {
  opacity: 0;
  transform: translateY(80px);
  -webkit-transform: translateY(80px);
  -moz-transform: translateY(80px);
  -ms-transform: translateY(80px);
  -o-transform: translateY(80px); }

.transition_container {
  position: absolute;
  background: #555566;
  top: 100%;
  left: 0px;
  height: 100%;
  width: 100%;
  z-index: 800;
  transition: all 5s ease 0s;
  -webkit-transition: all 5s ease 0s;
  -moz-transition: all 5s ease 0s;
  -ms-transition: all 5s ease 0s;
  -o-transition: all 5s ease 0s; }

.transition_container.up_transition {
  top: -100%;
  height: 0%; }

.transition_container.case {
  top: 0%;
  left: 0%; }

.transition_container.right_transition {
  left: 100%; }

.work_anim_container {
  position: absolute;
  top: 0%;
  left: 100%;
  height: 100%;
  width: 0%;
  background: #0f0f1d;
  z-index: 100;
  transition: all .8s ease-in 0s;
  -webkit-transition: all .8s ease-in 0s;
  -moz-transition: all .8s ease-in 0s;
  -ms-transition: all .8s ease-in 0s;
  -o-transition: all .8s ease-in 0s; }

.work_anim_container.animate_work {
  width: 100%;
  left: 0%; }

.container {
  background: #0f0f1d; }

.top_text {
  padding-left: 18vw;
  padding-top: 24vh;
  width: 62vw; }

.top_text_1 {
  font-size: 31.25px;
  font-family: "BasisGrotesqueRegular";
  line-height: 64px;
  color: #fff; }

.top_text_2 {
  font-family: "BasisGrotesqueRegular";
  font-size: 25px;
  line-height: 48px;
  color: #bbbbbb;
  margin-top: 8px; }

.copy_vertical {
  position: absolute;
  top: 0%;
  left: 8%; }

.copy_vertical_right {
  position: absolute;
  top: 52%;
  right: -44%;
  height: 96px;
  width: 100%; }

.copy_vertical, .copy_vertical_right {
  transform-style: preserve-3d;
  -webkit-transform-style: preserve-3d;
  -moz-transform-style: preserve-3d;
  -ms-transform-style: preserve-3d;
  -o-transform-style: preserve-3d; }

.copy_vertical_inner {
  position: absolute;
  width: 100vw;
  top: -25%;
  left: -700%;
  transform: rotate(-90deg);
  -moz-transform: rotte(-90deg);
  -webkit-transform: rotate(-90deg);
  -ms-transform: rotate(-90deg);
  -o-transform: rotate(-90deg); }

.copy_vertical_right_inner {
  position: absolute;
  color: #fff;
  width: 100vw;
  text-align: center;
  text-transform: uppercase;
  transform: rotate(-90deg);
  -moz-transform: rotte(-90deg);
  -webkit-transform: rotate(-90deg);
  -ms-transform: rotate(-90deg);
  -o-transform: rotate(-90deg); }

.seperator_circle {
  display: inline-block;
  height: 6px;
  width: 6px;
  border-radius: 50%;
  background: rgba(255, 255, 255, 0.3);
  margin: 0px 8px; }

.copy_vertical {
  color: #fff;
  text-transform: uppercase;
  width: 96px;
  height: 100%; }

.copy_span {
  display: inline;
  font-family: "BasisGrotesqueMedium"; }

.copy_span_right {
  display: inline-block;
  font-family: "BasisGrotesqueMedium"; }

.header_new_container {
  width: 100%;
  padding: 0px;
  will-change: transform; }

.header_logo {
  float: left;
  margin-left: 10vw; }

.header_menu {
  float: right;
  margin-right: 7%; }

.header_menu ul {
  list-style-type: none; }

.header_menu ul li {
  color: #fff;
  display: inline-block;
  padding-left: 36px; }

.header_menu ul li a {
  color: #fff;
  font-family: "BasisGrotesqueMedium"; }

.header_menu ul li a:after {
  background: #fff;
  top: 108%; }

.scroll_for_more {
  position: absolute;
  bottom: -8%;
  height: 64px;
  width: 100%;
  padding-left: 18vw; }

.scroll_for_more_text {
  font-family: "BasisGrotesqueRegular";
  font-size: 18px;
  display: inline-block;
  padding-right: 28px;
  vertical-align: top;
  margin-top: 0px;
  color: #fff; }

.scroll_for_more_line {
  height: 2px;
  width: 48vw;
  background: #889;
  display: inline-block; }

.litewallet_link {
  color: #8e68d9; }

.litewallet_link::After {
  color: #8e68d9; }

.litewallet_link::after {
  background: #8e68d9;
  top: 104%; }

#selected_works_container {
  margin-top: 12vh;
  padding-bottom: 6h;
  padding-left: 8vw;
  color: #fff; }

.selected_works_text {
  font-size: 31.25px;
  font-family: "BasisGrotesqueMedium";
  transform: translateY(0px) rotate(0deg);
  -webkit-transform: translateY(0px) rotate(0deg);
  -moz-transform: translateY(0px) rotate(0deg);
  -ms-transform: translateY(0px) rotate(0deg);
  -o-transform: translateY(0px) rotate(0deg);
  transition: all 0.65s cubic-bezier(0.31, 1.02, 0.84, 0.99) 0s;
  -webkit-transition: all 0.65s cubic-bezier(0.31, 1.02, 0.84, 0.99) 0s;
  -moz-transition: all 0.65s cubic-bezier(0.31, 1.02, 0.84, 0.99) 0s;
  -ms-transition: all 0.65s cubic-bezier(0.31, 1.02, 0.84, 0.99) 0s;
  -o-transition: all 0.65s cubic-bezier(0.31, 1.02, 0.84, 0.99) 0s; }

.selected_works_tag {
  font-size: 25px;
  margin: 12px 0px 12px 0px;
  transition-delay: .35s;
  -webkit-transition-delay: .35s;
  -moz-transition-delay: .35s;
  -ms-transition-delay: .35s;
  -o-transition-delay: .35s;
  transform: translateY(0px) rotate(0deg);
  -webkit-transform: translateY(0px) rotate(0deg);
  -moz-transform: translateY(0px) rotate(0deg);
  -ms-transform: translateY(0px) rotate(0deg);
  -o-transform: translateY(0px) rotate(0deg);
  transition: all 0.65s cubic-bezier(0.31, 1.02, 0.84, 0.99) 0s;
  -webkit-transition: all 0.65s cubic-bezier(0.31, 1.02, 0.84, 0.99) 0s;
  -moz-transition: all 0.65s cubic-bezier(0.31, 1.02, 0.84, 0.99) 0s;
  -ms-transition: all 0.65s cubic-bezier(0.31, 1.02, 0.84, 0.99) 0s;
  -o-transition: all 0.65s cubic-bezier(0.31, 1.02, 0.84, 0.99) 0s; }

.selected_works_line {
  background: #ccc; }

.hide_below {
  opacity: 0;
  transform: translateY(140px);
  -webkit-transform: translateY(140px);
  -moz-transform: translateY(140px);
  -ms-transform: translateY(140px);
  -o-transform: translateY(140px); }

.selected_works_content {
  padding-top: 32px; }

#footer {
  background: #fff;
  padding-bottom: 24px; }

.footer_text_1 {
  width: 100%;
  text-align: center; }

#footer_text_1 {
  font-size: 39.06px; }

#footer_text_2 {
  font-size: 25px;
  margin-top: 20px; }

#footer_text_1, #footer_text_2 {
  text-align: center; }

.footer_social_links {
  width: 100%;
  text-align: center;
  margin-top: 28px; }

.social_link {
  font-size: 20px;
  color: #777788;
  margin-left: 20px; }

.footer_copyright {
  font-size: 16px;
  width: 100%;
  text-align: center;
  margin-top: 68px;
  text-transform: uppercase;
  color: white; }

.footer_link_icon {
  display: inline-block; }

.footer_link_icon img {
  height: 12px;
  width: 12px; }

#goqii_container img:nth-child(1) {
  margin-left: -10%; }

#footer.dark_background #footer_text_1 {
  color: white; }

#footer.dark_background #footer_text_2 {
  color: white; }

.header_new_container .header_menu {
  padding: 32px 0px; }

.header_new_container .header_logo {
  padding-top: 24px;
  transition: all 0.6s cubic-bezier(0.52, 1.18, 0.87, 1.03) 0s;
  -webkit-transition: all 0.6s cubic-bezier(0.52, 1.18, 0.87, 1.03) 0s;
  -moz-transition: all 0.6s cubic-bezier(0.52, 1.18, 0.87, 1.03) 0s;
  -ms-transition: all 0.6s cubic-bezier(0.52, 1.18, 0.87, 1.03) 0s;
  -o-transition: all 0.6s cubic-bezier(0.52, 1.18, 0.87, 1.03) 0s; }

.header_new_container.hide .header_inner_new {
  opacity: 0;
  transition: all 0.4s cubic-bezier(0.52, 1.18, 0.87, 1.03) 0s;
  -webkit-transition: all 0.4s cubic-bezier(0.52, 1.18, 0.87, 1.03) 0s;
  -moz-transition: all 0.4s cubic-bezier(0.52, 1.18, 0.87, 1.03) 0s;
  -ms-transition: all 0.4s cubic-bezier(0.52, 1.18, 0.87, 1.03) 0s;
  -o-transition: all 0.4s cubic-bezier(0.52, 1.18, 0.87, 1.03) 0s; }

.about_head_title_1 {
  font-family: "BasisGrotesqueRegular";
  font-size: 16px;
  line-height: 24px;
  color: #9199de; }

#pvr_cinemas_container.work_container .work_cover_container img {
  margin-left: 4%; }

.header_new_container .header_menu .header_menu_list_item a::after {
  top: 114%; }

#pvr_cinemas_app_container.work_container .work_cover_container {
  width: 100%;
  bottom: 0%; }

#pvr_cinemas_app_container.work_container .work_cover_container img {
  position: absolute;
  bottom: 0%;
  margin-top: 0%; }

.header_menu_list_item a.selected {
  color: #9199de; }

.header_menu_list_item a.selected::after {
  background: #9199de;
  width: 100%; }

.container.dark_container .header_new_container.header_fixed .header_menu_list_item a {
  color: white; }

.container.dark_container .header_new_container.header_fixed .header_menu_list_item a.selected {
  color: #9199de; }

#about_container.container.dark_container .header_new_container.header_fixed .header_background {
  background: #303033; }

.header_logo a::after {
  display: none; }

.home_pattern_container {
  position: absolute;
  left: 0%;
  top: 0%;
  z-index: 10; }

.intro_new_container {
  position: absolute;
  top: 0px;
  left: 0px;
  height: 100vh;
  width: 100vw;
  z-index: 400;
  background: #0f0f1d;
  transition: all 1.2s cubic-bezier(0.19, 1, 0.22, 1) 0s;
  -webkit-transition: all 1.2s cubic-bezier(0.19, 1, 0.22, 1) 0s;
  -moz-transition: all 1.2s cubic-bezier(0.19, 1, 0.22, 1) 0s;
  -ms-transition: all 1.2s cubic-bezier(0.19, 1, 0.22, 1) 0s;
  -o-transition: all 1.2s cubic-bezier(0.19, 1, 0.22, 1) 0s; }

.intro_text_container {
  position: absolute;
  top: 37%;
  left: 20%;
  width: 60%;
  text-align: center; }

.intro_text_1 {
  font-family: "BasisGrotesqueMedium";
  font-size: 39.81px;
  color: white;
  width: 100%;
  text-align: center;
  letter-spacing: .03em;
  height: 64px;
  overflow: hidden;
  transition: all 0.6s cubic-bezier(0.19, 1, 0.22, 1);
  -webkit-transition: all 0.6s cubic-bezier(0.19, 1, 0.22, 1);
  -moz-transition: all 0.6s cubic-bezier(0.19, 1, 0.22, 1);
  -ms-transition: all 0.6s cubic-bezier(0.19, 1, 0.22, 1);
  -o-transition: all 0.6s cubic-bezier(0.19, 1, 0.22, 1); }

.intro_text_2 {
  font-family: "BasisGrotesqueRegular";
  font-size: 23.04px;
  color: white;
  width: 100%;
  text-align: center;
  height: 64px;
  overflow: hidden;
  transition: all 0.6s cubic-bezier(0.19, 1, 0.22, 1);
  -webkit-transition: all 0.6s cubic-bezier(0.19, 1, 0.22, 1);
  -moz-transition: all 0.6s cubic-bezier(0.19, 1, 0.22, 1);
  -ms-transition: all 0.6s cubic-bezier(0.19, 1, 0.22, 1);
  -o-transition: all 0.6s cubic-bezier(0.19, 1, 0.22, 1); }

.element_1_container {
  position: relative;
  left: 20%;
  width: 60%;
  text-align: center; }

.element_2_container {
  position: relative;
  left: 20%;
  width: 60%;
  text-align: center;
  margin-top: -40px; }

.element_1 {
  display: inline-block;
  width: 0px;
  height: 0px;
  background: #555566;
  margin-bottom: 8px; }

.element_2 {
  display: inline-block;
  width: 0px;
  height: 0px;
  background: #555566;
  margin-top: 32px;
  transition: all 0.4s cubic-bezier(0.31, 1.02, 0.84, 0.99) 0s;
  -webkit-transition: all 0.4s cubic-bezier(0.31, 1.02, 0.84, 0.99) 0s;
  -moz-transition: all 0.4s cubic-bezier(0.31, 1.02, 0.84, 0.99) 0s;
  -ms-transition: all 0.4s cubic-bezier(0.31, 1.02, 0.84, 0.99) 0s;
  -o-transition: all 0.4s cubic-bezier(0.31, 1.02, 0.84, 0.99) 0s; }

.element_2.show {
  height: 1px; }

.element_2.expand_width {
  width: 64px; }

.element_2.expand_height {
  height: 3px; }

.element_1, .element_2, .intro_text_1, .intro_text_2 {
  transition: all 1.1s cubic-bezier(0.52, 1.18, 0.87, 1.03) 0s;
  -webkit-transition: all 1.1s cubic-bezier(0.52, 1.18, 0.87, 1.03) 0s;
  -moz-transition: all 1.1s cubic-bezier(0.52, 1.18, 0.87, 1.03) 0s;
  -ms-transition: all 1.1s cubic-bezier(0.52, 1.18, 0.87, 1.03) 0s;
  -o-transition: all 1.1s cubic-bezier(0.52, 1.18, 0.87, 1.03) 0s; }

.intro_text_2, .element_2 {
  transition-delay: .11s;
  -webkit-transition-delay: .11s;
  -moz-transition-delay: .11s;
  -ms-transition-delay: .11s;
  -o-transition-delay: .11s; }

.hide_left {
  opacity: 0;
  transform: translateX(-85px);
  -webkit-transform: translateX(-85px);
  -moz-transform: translateX(-85px);
  -ms-transform: translateX(-85px);
  -o-transform: translateX(-85px); }

.hide_right {
  opacity: 0;
  transform: translateX(85px);
  -webkit-transform: translateX(85px);
  -moz-transform: translateX(85px);
  -ms-transform: translateX(85px);
  -o-transform: translateX(85px); }

.hide_left_fast {
  opacity: 0;
  transform: translateX(-150px);
  -webkit-transform: translateX(-150px);
  -moz-transform: translateX(-150px);
  -ms-transform: translateX(-150px);
  -o-transform: translateX(-150px); }

.hide_right_fast {
  opacity: 0;
  transform: translateX(150px);
  -webkit-transform: translateX(150px);
  -moz-transform: translateX(150px);
  -ms-transform: translateX(150px);
  -o-transform: translateX(150px); }

.about_large_title {
  font-size: 47.76px;
  font-family: "BasisGrotesqueRegular";
  line-height: 64px;
  margin-top: 8vh; }

.go_up {
  transform: translateY(-100%);
  -webkit-transform: translateY(-100%);
  -moz-transform: translateY(-100%);
  -ms-transform: translateY(-100%);
  -o-transform: translateY(-100%); }

.work_desc_title_2 {
  font-family: "BasisGrotesqueMedium";
  font-size: 27.65px;
  display: inline-block;
  padding-bottom: 4px;
  border-bottom: 2px solid #aaa;
  color: #555; }

#pvr_cinemas_app_container .work_desc_title_2 {
  color: #444455; }

#studycopter_container .work_desc_title_2, #crosschecks_container .work_desc_title_2, #murals_container .work_desc_title_2, #goqii_container .work_desc_title_2, #pvr_cinemas_container .work_desc_title_2, #litewallet_container .work_desc_title_2, #feetapart_container .work_desc_title_2 {
  color: #fff;
  border-bottom-color: rgba(255, 255, 255, 0.6); }

#home_container .header_new_container.header_fixed .header_background {
  background: #303033; }

.header_new_container.dark_header {
  box-shadow: none;
  -webkit-box-shadow: none;
  -moz-box-shadow: none;
  -ms-box-shadow: none;
  -o-box-shadow: none; }

.header_new_container.dark_header .header_logo, .header_new_container.dark_header .header_menu {
  z-index: 60;
  position: relative; }

a.over::after {
  width: 100%;
  transition: all .3s; }

a.out::after {
  transition: all .3s;
  transform: translateX(110%);
  -webkit-transform: translateX(110%);
  -moz-transform: translateX(110%);
  -ms-transform: translateX(110%);
  -o-transform: translateX(110%); }

a.hide::after {
  opacity: 0;
  transition: all .3s; }

.element_1.expand_width {
  width: 64px; }

.element_1.expand_height {
  height: 3px; }

.about_head_large_desc {
  font-family: "BasisGrotesqueRegular";
  font-size: 23.04px;
  line-height: 44px;
  margin-top: 12px;
  color: #bbbbbb; }

.text_word {
  display: inline;
  color: #bbb;
  transition: all 1.2s cubic-bezier(0.19, 1, 0.22, 1) 0s;
  -webkit-transition: all 1.2s cubic-bezier(0.19, 1, 0.22, 1) 0s;
  -moz-transition: all 1.2s cubic-bezier(0.19, 1, 0.22, 1) 0s;
  -ms-transition: all 1.2s cubic-bezier(0.19, 1, 0.22, 1) 0s;
  -o-transition: all 1.2s cubic-bezier(0.19, 1, 0.22, 1) 0s; }

.intro_text_1 .text_word {
  color: #fff; }

.intro_text_1 .text_word {
  margin-left: -13px; }

.intro_text_1 .text_word:nth-child(7) {
  margin-left: 0px; }

.intro_text_2 .text_word {
  margin-left: -6px; }

.intro_text_inner {
  height: 48px;
  overflow: hidden; }

.intro_text_2 .intro_text_inner {
  height: 32px; }

.text_word_single:nth-child(1) {
  transition-delay: 0.06s;
  -webkit-transition-delay: 0.06s;
  -moz-transition-delay: 0.06s;
  -ms-transition-delay: 0.06s;
  -o-transition-delay: 0.06s; }

.text_word_single:nth-child(2) {
  transition-delay: 0.12s;
  -webkit-transition-delay: 0.12s;
  -moz-transition-delay: 0.12s;
  -ms-transition-delay: 0.12s;
  -o-transition-delay: 0.12s; }

.text_word_single:nth-child(3) {
  transition-delay: 0.18s;
  -webkit-transition-delay: 0.18s;
  -moz-transition-delay: 0.18s;
  -ms-transition-delay: 0.18s;
  -o-transition-delay: 0.18s; }

.text_word_single:nth-child(4) {
  transition-delay: 0.24s;
  -webkit-transition-delay: 0.24s;
  -moz-transition-delay: 0.24s;
  -ms-transition-delay: 0.24s;
  -o-transition-delay: 0.24s; }

.text_word_single:nth-child(5) {
  transition-delay: 0.3s;
  -webkit-transition-delay: 0.3s;
  -moz-transition-delay: 0.3s;
  -ms-transition-delay: 0.3s;
  -o-transition-delay: 0.3s; }

.text_word_single:nth-child(6) {
  transition-delay: 0.36s;
  -webkit-transition-delay: 0.36s;
  -moz-transition-delay: 0.36s;
  -ms-transition-delay: 0.36s;
  -o-transition-delay: 0.36s; }

.text_word_single:nth-child(7) {
  transition-delay: 0.42s;
  -webkit-transition-delay: 0.42s;
  -moz-transition-delay: 0.42s;
  -ms-transition-delay: 0.42s;
  -o-transition-delay: 0.42s; }

.text_word_single:nth-child(8) {
  transition-delay: 0.48s;
  -webkit-transition-delay: 0.48s;
  -moz-transition-delay: 0.48s;
  -ms-transition-delay: 0.48s;
  -o-transition-delay: 0.48s; }

.text_word_single:nth-child(9) {
  transition-delay: 0.54s;
  -webkit-transition-delay: 0.54s;
  -moz-transition-delay: 0.54s;
  -ms-transition-delay: 0.54s;
  -o-transition-delay: 0.54s; }

.text_word_single:nth-child(10) {
  transition-delay: 0.6s;
  -webkit-transition-delay: 0.6s;
  -moz-transition-delay: 0.6s;
  -ms-transition-delay: 0.6s;
  -o-transition-delay: 0.6s; }

.text_word_single:nth-child(11) {
  transition-delay: 0.66s;
  -webkit-transition-delay: 0.66s;
  -moz-transition-delay: 0.66s;
  -ms-transition-delay: 0.66s;
  -o-transition-delay: 0.66s; }

.text_word_single:nth-child(12) {
  transition-delay: 0.72s;
  -webkit-transition-delay: 0.72s;
  -moz-transition-delay: 0.72s;
  -ms-transition-delay: 0.72s;
  -o-transition-delay: 0.72s; }

.text_word_single:nth-child(13) {
  transition-delay: 0.78s;
  -webkit-transition-delay: 0.78s;
  -moz-transition-delay: 0.78s;
  -ms-transition-delay: 0.78s;
  -o-transition-delay: 0.78s; }

.text_word_single:nth-child(14) {
  transition-delay: 0.84s;
  -webkit-transition-delay: 0.84s;
  -moz-transition-delay: 0.84s;
  -ms-transition-delay: 0.84s;
  -o-transition-delay: 0.84s; }

.text_word_single:nth-child(15) {
  transition-delay: 0.9s;
  -webkit-transition-delay: 0.9s;
  -moz-transition-delay: 0.9s;
  -ms-transition-delay: 0.9s;
  -o-transition-delay: 0.9s; }

.text_word_single:nth-child(16) {
  transition-delay: 0.96s;
  -webkit-transition-delay: 0.96s;
  -moz-transition-delay: 0.96s;
  -ms-transition-delay: 0.96s;
  -o-transition-delay: 0.96s; }

.text_word_single:nth-child(17) {
  transition-delay: 1.02s;
  -webkit-transition-delay: 1.02s;
  -moz-transition-delay: 1.02s;
  -ms-transition-delay: 1.02s;
  -o-transition-delay: 1.02s; }

.text_word_single:nth-child(18) {
  transition-delay: 1.08s;
  -webkit-transition-delay: 1.08s;
  -moz-transition-delay: 1.08s;
  -ms-transition-delay: 1.08s;
  -o-transition-delay: 1.08s; }

.text_word_single:nth-child(19) {
  transition-delay: 1.14s;
  -webkit-transition-delay: 1.14s;
  -moz-transition-delay: 1.14s;
  -ms-transition-delay: 1.14s;
  -o-transition-delay: 1.14s; }

.text_word_single:nth-child(20) {
  transition-delay: 1.2s;
  -webkit-transition-delay: 1.2s;
  -moz-transition-delay: 1.2s;
  -ms-transition-delay: 1.2s;
  -o-transition-delay: 1.2s; }

.text_word_single:nth-child(21) {
  transition-delay: 1.26s;
  -webkit-transition-delay: 1.26s;
  -moz-transition-delay: 1.26s;
  -ms-transition-delay: 1.26s;
  -o-transition-delay: 1.26s; }

.text_word_single:nth-child(22) {
  transition-delay: 1.32s;
  -webkit-transition-delay: 1.32s;
  -moz-transition-delay: 1.32s;
  -ms-transition-delay: 1.32s;
  -o-transition-delay: 1.32s; }

.text_word_single:nth-child(23) {
  transition-delay: 1.38s;
  -webkit-transition-delay: 1.38s;
  -moz-transition-delay: 1.38s;
  -ms-transition-delay: 1.38s;
  -o-transition-delay: 1.38s; }

.text_word_single:nth-child(24) {
  transition-delay: 1.44s;
  -webkit-transition-delay: 1.44s;
  -moz-transition-delay: 1.44s;
  -ms-transition-delay: 1.44s;
  -o-transition-delay: 1.44s; }

.text_word_single:nth-child(25) {
  transition-delay: 1.5s;
  -webkit-transition-delay: 1.5s;
  -moz-transition-delay: 1.5s;
  -ms-transition-delay: 1.5s;
  -o-transition-delay: 1.5s; }

.text_word_single:nth-child(26) {
  transition-delay: 1.56s;
  -webkit-transition-delay: 1.56s;
  -moz-transition-delay: 1.56s;
  -ms-transition-delay: 1.56s;
  -o-transition-delay: 1.56s; }

.text_word_single:nth-child(27) {
  transition-delay: 1.62s;
  -webkit-transition-delay: 1.62s;
  -moz-transition-delay: 1.62s;
  -ms-transition-delay: 1.62s;
  -o-transition-delay: 1.62s; }

.text_word_single:nth-child(28) {
  transition-delay: 1.68s;
  -webkit-transition-delay: 1.68s;
  -moz-transition-delay: 1.68s;
  -ms-transition-delay: 1.68s;
  -o-transition-delay: 1.68s; }

.text_word_single:nth-child(29) {
  transition-delay: 1.74s;
  -webkit-transition-delay: 1.74s;
  -moz-transition-delay: 1.74s;
  -ms-transition-delay: 1.74s;
  -o-transition-delay: 1.74s; }

.text_word_single:nth-child(30) {
  transition-delay: 1.8s;
  -webkit-transition-delay: 1.8s;
  -moz-transition-delay: 1.8s;
  -ms-transition-delay: 1.8s;
  -o-transition-delay: 1.8s; }

.text_word_single:nth-child(31) {
  transition-delay: 1.86s;
  -webkit-transition-delay: 1.86s;
  -moz-transition-delay: 1.86s;
  -ms-transition-delay: 1.86s;
  -o-transition-delay: 1.86s; }

.text_word_single:nth-child(32) {
  transition-delay: 1.92s;
  -webkit-transition-delay: 1.92s;
  -moz-transition-delay: 1.92s;
  -ms-transition-delay: 1.92s;
  -o-transition-delay: 1.92s; }

.text_word_single:nth-child(33) {
  transition-delay: 1.98s;
  -webkit-transition-delay: 1.98s;
  -moz-transition-delay: 1.98s;
  -ms-transition-delay: 1.98s;
  -o-transition-delay: 1.98s; }

.text_word_single:nth-child(34) {
  transition-delay: 2.04s;
  -webkit-transition-delay: 2.04s;
  -moz-transition-delay: 2.04s;
  -ms-transition-delay: 2.04s;
  -o-transition-delay: 2.04s; }

.text_word_single:nth-child(35) {
  transition-delay: 2.1s;
  -webkit-transition-delay: 2.1s;
  -moz-transition-delay: 2.1s;
  -ms-transition-delay: 2.1s;
  -o-transition-delay: 2.1s; }

.text_word_single:nth-child(36) {
  transition-delay: 2.16s;
  -webkit-transition-delay: 2.16s;
  -moz-transition-delay: 2.16s;
  -ms-transition-delay: 2.16s;
  -o-transition-delay: 2.16s; }

.text_word_single:nth-child(37) {
  transition-delay: 2.22s;
  -webkit-transition-delay: 2.22s;
  -moz-transition-delay: 2.22s;
  -ms-transition-delay: 2.22s;
  -o-transition-delay: 2.22s; }

.text_word_single:nth-child(38) {
  transition-delay: 2.28s;
  -webkit-transition-delay: 2.28s;
  -moz-transition-delay: 2.28s;
  -ms-transition-delay: 2.28s;
  -o-transition-delay: 2.28s; }

.text_word_single:nth-child(39) {
  transition-delay: 2.34s;
  -webkit-transition-delay: 2.34s;
  -moz-transition-delay: 2.34s;
  -ms-transition-delay: 2.34s;
  -o-transition-delay: 2.34s; }

.text_word_single:nth-child(40) {
  transition-delay: 2.4s;
  -webkit-transition-delay: 2.4s;
  -moz-transition-delay: 2.4s;
  -ms-transition-delay: 2.4s;
  -o-transition-delay: 2.4s; }

.text_word_single {
  display: inline-block;
  opacity: 0;
  transform: translateY(80px);
  -webkit-transform: translateY(80px);
  -moz-transform: translateY(80px);
  -ms-transform: translateY(80px);
  -o-transform: translateY(80px);
  transition: all 0.5s cubic-bezier(0.31, 1.02, 0.84, 0.99) 0s;
  -webkit-transition: all 0.5s cubic-bezier(0.31, 1.02, 0.84, 0.99) 0s;
  -moz-transition: all 0.5s cubic-bezier(0.31, 1.02, 0.84, 0.99) 0s;
  -ms-transition: all 0.5s cubic-bezier(0.31, 1.02, 0.84, 0.99) 0s;
  -o-transition: all 0.5s cubic-bezier(0.31, 1.02, 0.84, 0.99) 0s; }

.word_break {
  margin-left: 12px; }

.intro_text_2 .text_word_single.word_break {
  margin-left: 7px; }

.up_and_show {
  opacity: 1;
  transform: translateY(0px);
  -webkit-transform: translateY(0px);
  -moz-transform: translateY(0px);
  -ms-transform: translateY(0px);
  -o-transform: translateY(0px); }

.change_color {
  color: #fff; }

.go_left_and_hide {
  opacity: 0;
  transform: translateX(-60px);
  -webkit-transform: translateX(-60px);
  -moz-transform: translateX(-60px);
  -ms-transform: translateX(-60px);
  -o-transform: translateX(-60px); }

.hide {
  opacity: 0; }

.go_up {
  transform: translateY(-100%);
  -webkit-transform: translateY(-100%);
  -moz-transform: translateY(-100%);
  -ms-transform: translateY(-100%);
  -o-transform: translateY(-100%); }

.about_pic_container img {
  margin-top: -3vh;
  margin-left: 2vw;
  /*
  
  box-shadow:1px -1px 5px 5px #333;
  -webkit-box-shadow:1px -1px 5px 5px #333;
  -moz-box-shadow:1px -1px 5px 5px #333;
  -ms-box-shadow:1px -1px 5px 5px #333;
  -o-box-shadow:1px -1px 5px 5px #333;
  
  */ }

.coming_soon_title {
  display: inline;
  position: relative;
  top: -4px;
  color: rgba(0, 0, 0, 0.3);
  font-size: 27.65px;
  font-family: "BasisGrotesqueMedium"; }

.work_container.coming_soon .text_word {
  margin-left: -5px; }

.work_container.coming_soon .text_word.dim {
  color: rgba(255, 255, 255, 0.4); }

.work_container.coming_soon .text_word {
  color: white; }

.work_container.coming_soon .text_word_single {
  opacity: 1;
  transform: translateY(0px);
  -webkit-transform: translateY(0px);
  -moz-transform: translateY(0px);
  -ms-transform: translateY(0px);
  -o-transform: translateY(0px); }

.work_word {
  display: inline-block;
  line-height: 48px;
  transition: all 1.2s cubic-bezier(0.19, 1, 0.22, 1) 0s;
  -webkit-transition: all 1.2s cubic-bezier(0.19, 1, 0.22, 1) 0s;
  -moz-transition: all 1.2s cubic-bezier(0.19, 1, 0.22, 1) 0s;
  -ms-transition: all 1.2s cubic-bezier(0.19, 1, 0.22, 1) 0s;
  -o-transition: all 1.2s cubic-bezier(0.19, 1, 0.22, 1) 0s;
  opacity: 0;
  transform: translateY(140px);
  -webkit-transform: translateY(140px);
  -moz-transform: translateY(140px);
  -ms-transform: translateY(140px);
  -o-transform: translateY(140px); }

.work_word.show {
  opacity: 1;
  transform: translateY(0px);
  -webkit-transform: translateY(0px);
  -moz-transform: translateY(0px);
  -ms-transform: translateY(0px);
  -o-transform: translateY(0px); }

.work_word[word_number="1"] {
  transition-delay: 0.02s;
  -webkit-transition-delay: 0.02s;
  -moz-transition-delay: 0.02s;
  -ms-transition-delay: 0.02s;
  -o-transition-delay: 0.02s; }

.work_word[word_number="2"] {
  transition-delay: 0.04s;
  -webkit-transition-delay: 0.04s;
  -moz-transition-delay: 0.04s;
  -ms-transition-delay: 0.04s;
  -o-transition-delay: 0.04s; }

.work_word[word_number="3"] {
  transition-delay: 0.06s;
  -webkit-transition-delay: 0.06s;
  -moz-transition-delay: 0.06s;
  -ms-transition-delay: 0.06s;
  -o-transition-delay: 0.06s; }

.work_word[word_number="4"] {
  transition-delay: 0.08s;
  -webkit-transition-delay: 0.08s;
  -moz-transition-delay: 0.08s;
  -ms-transition-delay: 0.08s;
  -o-transition-delay: 0.08s; }

.work_word[word_number="5"] {
  transition-delay: 0.1s;
  -webkit-transition-delay: 0.1s;
  -moz-transition-delay: 0.1s;
  -ms-transition-delay: 0.1s;
  -o-transition-delay: 0.1s; }

.work_word[word_number="6"] {
  transition-delay: 0.12s;
  -webkit-transition-delay: 0.12s;
  -moz-transition-delay: 0.12s;
  -ms-transition-delay: 0.12s;
  -o-transition-delay: 0.12s; }

.work_word[word_number="7"] {
  transition-delay: 0.14s;
  -webkit-transition-delay: 0.14s;
  -moz-transition-delay: 0.14s;
  -ms-transition-delay: 0.14s;
  -o-transition-delay: 0.14s; }

.work_word[word_number="8"] {
  transition-delay: 0.16s;
  -webkit-transition-delay: 0.16s;
  -moz-transition-delay: 0.16s;
  -ms-transition-delay: 0.16s;
  -o-transition-delay: 0.16s; }

.work_word[word_number="9"] {
  transition-delay: 0.18s;
  -webkit-transition-delay: 0.18s;
  -moz-transition-delay: 0.18s;
  -ms-transition-delay: 0.18s;
  -o-transition-delay: 0.18s; }

.work_word[word_number="10"] {
  transition-delay: 0.2s;
  -webkit-transition-delay: 0.2s;
  -moz-transition-delay: 0.2s;
  -ms-transition-delay: 0.2s;
  -o-transition-delay: 0.2s; }

.work_word[word_number="11"] {
  transition-delay: 0.22s;
  -webkit-transition-delay: 0.22s;
  -moz-transition-delay: 0.22s;
  -ms-transition-delay: 0.22s;
  -o-transition-delay: 0.22s; }

.work_word[word_number="12"] {
  transition-delay: 0.24s;
  -webkit-transition-delay: 0.24s;
  -moz-transition-delay: 0.24s;
  -ms-transition-delay: 0.24s;
  -o-transition-delay: 0.24s; }

.work_word[word_number="13"] {
  transition-delay: 0.26s;
  -webkit-transition-delay: 0.26s;
  -moz-transition-delay: 0.26s;
  -ms-transition-delay: 0.26s;
  -o-transition-delay: 0.26s; }

.work_word[word_number="14"] {
  transition-delay: 0.28s;
  -webkit-transition-delay: 0.28s;
  -moz-transition-delay: 0.28s;
  -ms-transition-delay: 0.28s;
  -o-transition-delay: 0.28s; }

.work_word[word_number="15"] {
  transition-delay: 0.3s;
  -webkit-transition-delay: 0.3s;
  -moz-transition-delay: 0.3s;
  -ms-transition-delay: 0.3s;
  -o-transition-delay: 0.3s; }

.work_word[word_number="16"] {
  transition-delay: 0.32s;
  -webkit-transition-delay: 0.32s;
  -moz-transition-delay: 0.32s;
  -ms-transition-delay: 0.32s;
  -o-transition-delay: 0.32s; }

.work_word[word_number="17"] {
  transition-delay: 0.34s;
  -webkit-transition-delay: 0.34s;
  -moz-transition-delay: 0.34s;
  -ms-transition-delay: 0.34s;
  -o-transition-delay: 0.34s; }

.work_word[word_number="18"] {
  transition-delay: 0.36s;
  -webkit-transition-delay: 0.36s;
  -moz-transition-delay: 0.36s;
  -ms-transition-delay: 0.36s;
  -o-transition-delay: 0.36s; }

.work_word[word_number="19"] {
  transition-delay: 0.38s;
  -webkit-transition-delay: 0.38s;
  -moz-transition-delay: 0.38s;
  -ms-transition-delay: 0.38s;
  -o-transition-delay: 0.38s; }

.work_word[word_number="20"] {
  transition-delay: 0.4s;
  -webkit-transition-delay: 0.4s;
  -moz-transition-delay: 0.4s;
  -ms-transition-delay: 0.4s;
  -o-transition-delay: 0.4s; }

.work_word[word_number="21"] {
  transition-delay: 0.42s;
  -webkit-transition-delay: 0.42s;
  -moz-transition-delay: 0.42s;
  -ms-transition-delay: 0.42s;
  -o-transition-delay: 0.42s; }

.work_word[word_number="22"] {
  transition-delay: 0.44s;
  -webkit-transition-delay: 0.44s;
  -moz-transition-delay: 0.44s;
  -ms-transition-delay: 0.44s;
  -o-transition-delay: 0.44s; }

.work_word[word_number="23"] {
  transition-delay: 0.46s;
  -webkit-transition-delay: 0.46s;
  -moz-transition-delay: 0.46s;
  -ms-transition-delay: 0.46s;
  -o-transition-delay: 0.46s; }

.work_word[word_number="24"] {
  transition-delay: 0.48s;
  -webkit-transition-delay: 0.48s;
  -moz-transition-delay: 0.48s;
  -ms-transition-delay: 0.48s;
  -o-transition-delay: 0.48s; }

.work_word[word_number="25"] {
  transition-delay: 0.5s;
  -webkit-transition-delay: 0.5s;
  -moz-transition-delay: 0.5s;
  -ms-transition-delay: 0.5s;
  -o-transition-delay: 0.5s; }

.work_word[word_number="26"] {
  transition-delay: 0.52s;
  -webkit-transition-delay: 0.52s;
  -moz-transition-delay: 0.52s;
  -ms-transition-delay: 0.52s;
  -o-transition-delay: 0.52s; }

.work_word[word_number="27"] {
  transition-delay: 0.54s;
  -webkit-transition-delay: 0.54s;
  -moz-transition-delay: 0.54s;
  -ms-transition-delay: 0.54s;
  -o-transition-delay: 0.54s; }

.work_word[word_number="28"] {
  transition-delay: 0.56s;
  -webkit-transition-delay: 0.56s;
  -moz-transition-delay: 0.56s;
  -ms-transition-delay: 0.56s;
  -o-transition-delay: 0.56s; }

.work_word[word_number="29"] {
  transition-delay: 0.58s;
  -webkit-transition-delay: 0.58s;
  -moz-transition-delay: 0.58s;
  -ms-transition-delay: 0.58s;
  -o-transition-delay: 0.58s; }

.work_word[word_number="30"] {
  transition-delay: 0.6s;
  -webkit-transition-delay: 0.6s;
  -moz-transition-delay: 0.6s;
  -ms-transition-delay: 0.6s;
  -o-transition-delay: 0.6s; }

.work_word[word_number="31"] {
  transition-delay: 0.62s;
  -webkit-transition-delay: 0.62s;
  -moz-transition-delay: 0.62s;
  -ms-transition-delay: 0.62s;
  -o-transition-delay: 0.62s; }

.work_word[word_number="32"] {
  transition-delay: 0.64s;
  -webkit-transition-delay: 0.64s;
  -moz-transition-delay: 0.64s;
  -ms-transition-delay: 0.64s;
  -o-transition-delay: 0.64s; }

.work_word[word_number="33"] {
  transition-delay: 0.66s;
  -webkit-transition-delay: 0.66s;
  -moz-transition-delay: 0.66s;
  -ms-transition-delay: 0.66s;
  -o-transition-delay: 0.66s; }

.work_word[word_number="34"] {
  transition-delay: 0.68s;
  -webkit-transition-delay: 0.68s;
  -moz-transition-delay: 0.68s;
  -ms-transition-delay: 0.68s;
  -o-transition-delay: 0.68s; }

.work_word[word_number="35"] {
  transition-delay: 0.7s;
  -webkit-transition-delay: 0.7s;
  -moz-transition-delay: 0.7s;
  -ms-transition-delay: 0.7s;
  -o-transition-delay: 0.7s; }

.work_word[word_number="36"] {
  transition-delay: 0.72s;
  -webkit-transition-delay: 0.72s;
  -moz-transition-delay: 0.72s;
  -ms-transition-delay: 0.72s;
  -o-transition-delay: 0.72s; }

.work_word[word_number="37"] {
  transition-delay: 0.74s;
  -webkit-transition-delay: 0.74s;
  -moz-transition-delay: 0.74s;
  -ms-transition-delay: 0.74s;
  -o-transition-delay: 0.74s; }

.work_word[word_number="38"] {
  transition-delay: 0.76s;
  -webkit-transition-delay: 0.76s;
  -moz-transition-delay: 0.76s;
  -ms-transition-delay: 0.76s;
  -o-transition-delay: 0.76s; }

.work_word[word_number="39"] {
  transition-delay: 0.78s;
  -webkit-transition-delay: 0.78s;
  -moz-transition-delay: 0.78s;
  -ms-transition-delay: 0.78s;
  -o-transition-delay: 0.78s; }

.work_word[word_number="40"] {
  transition-delay: 0.8s;
  -webkit-transition-delay: 0.8s;
  -moz-transition-delay: 0.8s;
  -ms-transition-delay: 0.8s;
  -o-transition-delay: 0.8s; }

.work_word_container {
  height: 64px;
  line-height: 64px;
  margin-top: -12px;
  overflow: hidden; }

.show_from_left {
  opacity: 1;
  transform: translateX(0px);
  -webkit-transform: translateX(0px);
  -moz-transform: translateX(0px);
  -ms-transform: translateX(0px);
  -o-transform: translateX(0px); }

.hide_left {
  opacity: 0;
  transform: translateX(-140px);
  -webkit-transform: translateX(-140px);
  -moz-transform: translateX(-140px);
  -ms-transform: translateX(-140px);
  -o-transform: translateX(-140px); }

.intro_text_2.hide_left {
  transition-delay: .5s;
  -webkit-transition-delay: .5s;
  -moz-transition-delay: .5s;
  -ms-transition-delay: .5s;
  -o-transition-delay: .5s; }

.element_2.hide_left {
  transition-delay: .8s;
  -webkit-transition-delay: .8s;
  -moz-transition-delay: .8s;
  -ms-transition-delay: .8s;
  -o-transition-delay: .8s; }

.intro_text_2.hide_left, .element_2.hide_left {
  transition: all 0.9s cubic-bezier(0.19, 1, 0.22, 1) 0s;
  -webkit-transition: all 0.9s cubic-bezier(0.19, 1, 0.22, 1) 0s;
  -moz-transition: all 0.9s cubic-bezier(0.19, 1, 0.22, 1) 0s;
  -ms-transition: all 0.9s cubic-bezier(0.19, 1, 0.22, 1) 0s;
  -o-transition: all 0.9s cubic-bezier(0.19, 1, 0.22, 1) 0s; }

.intro_text_1.hide_left {
  transition: all 0.9s cubic-bezier(0.19, 1, 0.22, 1) 0s;
  -webkit-transition: all 0.9s cubic-bezier(0.19, 1, 0.22, 1) 0s;
  -moz-transition: all 0.9s cubic-bezier(0.19, 1, 0.22, 1) 0s;
  -ms-transition: all 0.9s cubic-bezier(0.19, 1, 0.22, 1) 0s;
  -o-transition: all 0.9s cubic-bezier(0.19, 1, 0.22, 1) 0s; }

#litewallet_container .work_cover_container img {
  margin-top: -1%; }

.work_word_inner_container {
  height: 48px;
  overflow: hidden; }

.scroll_for_more_container {
  padding-left: 18vw;
  position: absolute;
  bottom: 0%; }

.scroll_for_more_text {
  font-family: "BasisGrotesqueRegular";
  font-size: 16px;
  color: rgba(255, 255, 255, 0.7);
  display: inline-block;
  text-transform: uppercase; }

.scroll_for_more_line {
  display: inline-block;
  height: 2px;
  background: rgba(255, 255, 255, 0.2);
  width: 52vw;
  margin-left: -8px; }

.work_container.show .work_cover_container {
  opacity: 1;
  transform: translateY(0px);
  -webkit-transform: translateY(0px);
  -moz-transform: translateY(0px);
  -ms-transform: translateY(0px);
  -o-transform: translateY(0px); }

#footer.footer.light_background {
  background: linear-gradient(to bottom, #f6f6f6, #fcfcfc); }

.footer.light_background {
  color: rgba(0, 0, 0, 0.87); }

.footer.light_background .footer_copyright {
  color: rgba(0, 0, 0, 0.87); }

#footer.footer.light_background a {
  color: #4A57C9; }

.work_transition_container {
  position: absolute;
  top: 0px;
  left: 0px;
  height: 100%;
  width: 100%;
  z-index: 200;
  transform: scale(0);
  -webkit-transform: scale(0);
  -moz-transform: scale(0);
  -ms-transform: scale(0);
  -o-transform: scale(0); }

.work_container.animate_work_left {
  width: 0%; }

.animate_work_right .work_anim_container {
  left: 0%;
  width: 100%; }

.work_container.show .work_desc_date {
  opacity: 1;
  transform: translateX(0px);
  -webkit-transform: translateX(0px);
  -moz-transform: translateX(0px);
  -ms-transform: translateX(0px);
  -o-transform: translateX(0px);
  transition: all 0.9s cubic-bezier(0.19, 1, 0.22, 1) 1.55s;
  -webkit-transition: all 0.9s cubic-bezier(0.19, 1, 0.22, 1) 1.55s;
  -moz-transition: all 0.9s cubic-bezier(0.19, 1, 0.22, 1) 1.55s;
  -ms-transition: all 0.9s cubic-bezier(0.19, 1, 0.22, 1) 1.55s;
  -o-transition: all 0.9s cubic-bezier(0.19, 1, 0.22, 1) 1.55s; }

.case_study_button_container {
  margin-top: 16px; }

.case_study_button {
  display: inline-block;
  font-family: "BasisGrotesqueMedium";
  font-size: 16px;
  color: white;
  padding: 0px 24px;
  border-radius: 32px; }

.case_study_button a {
  color: white; }

.case_study_button img {
  margin-left: 8px;
  margin-top: 14px; }

.case_study_button_text {
  display: inline;
  line-height: 36px; }

/*# sourceMappingURL=style.cs.map */
