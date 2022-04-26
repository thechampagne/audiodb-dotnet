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
    public class Track
    {
        public string idTrack;
        public string idAlbum;
        public string idArtist;
        public string idLyric;
        public string idIMVDB;
        public string strTrack;
        public string strAlbum;
        public string strArtist;
        public string strArtistAlternate;
        public string intCD;
        public string intDuration;
        public string strGenre;
        public string strMood;
        public string strStyle;
        public string strTheme;
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
        public string strTrackThumb;
        public string strTrack3DCase;
        public string strTrackLyrics;
        public string strMusicVid;
        public string strMusicVidDirector;
        public string strMusicVidCompany;
        public string strMusicVidScreen1;
        public string strMusicVidScreen2;
        public string strMusicVidScreen3;
        public string intMusicVidViews;
        public string intMusicVidLikes;
        public string intMusicVidDislikes;
        public string intMusicVidFavorites;
        public string intMusicVidComments;
        public string intTrackNumber;
        public string intLoved;
        public string intScore;
        public string intScoreVotes;
        public string intTotalListeners;
        public string intTotalPlays;
        public string strMusicBrainzID;
        public string strMusicBrainzAlbumID;
        public string strMusicBrainzArtistID;
        public string strLocked;
    }

    class BaseTrack
    {
        public List<Track> track;
    }
}