/*
 * Copyright 2022 XXIV
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System.Collections.Generic;

namespace AudioDB
{
    public class Album
    {
        public string idAlbum;
        public string idArtist;
        public string idLabel;
        public string strAlbum;
        public string strAlbumStripped;
        public string strArtist;
        public string strArtistStripped;
        public string intYearReleased;
        public string strStyle;
        public string strGenre;
        public string strLabel;
        public string strReleaseFormat;
        public string intSales;
        public string strAlbumThumb;
        public string strAlbumThumbHQ;
        public string strAlbumThumbBack;
        public string strAlbumCDart;
        public string strAlbumSpine;
        public string strAlbum3DCase;
        public string strAlbum3DFlat;
        public string strAlbum3DFace;
        public string strAlbum3DThumb;
        public string strDescriptionEN;
        public string strDescriptionDE;
        public string strDescriptionFR;
        public string strDescriptionCN;
        public string strDescriptionIT;
        public string strDescriptionJP;
        public string strDescriptionRU;
        public string strDescriptionES;
        public string strDescriptionPT;
        public string strDescriptionSE;
        public string strDescriptionNL;
        public string strDescriptionHU;
        public string strDescriptionNO;
        public string strDescriptionIL;
        public string strDescriptionPL;
        public string intLoved;
        public string intScore;
        public string intScoreVotes;
        public string strReview;
        public string strMood;
        public string strTheme;
        public string strSpeed;
        public string strLocation;
        public string strMusicBrainzID;
        public string strMusicBrainzArtistID;
        public string strAllMusicID;
        public string strBBCReviewID;
        public string strRateYourMusicID;
        public string strDiscogsID;
        public string strWikidataID;
        public string strWikipediaID;
        public string strGeniusID;
        public string strLyricWikiID;
        public string strMusicMozID;
        public string strItunesID;
        public string strAmazonID;
        public string strLocked;
        public string strDescription;
    }

    class BaseAlbum
    {
        public List<Album> album;
    }
}